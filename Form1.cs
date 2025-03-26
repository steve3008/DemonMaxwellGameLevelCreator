using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DemonMaxwellGameLevelCreator
{
    public partial class Form1: Form
    {
        Bitmap _bmpBck = null;
        public static Rectangle _rectBounds;
        string _sLevelFile = "";
        int _iLevelFileVersion = 1;
        int _iCurrentLevel = 0;
        int _iNumWalls = 0;
        int _iTotalNumBalls = 0;
        int _iNumBallSets = 0;
        int _iNumObjects = 0;
        ObjBase[] _Objects = null;
        int _iObjSelected = -1;

        public Form1()
        {
            InitializeComponent();
            DrawFuncs.Initialize();
        }

        private void toolStripButtonLoadBck_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "png files (*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dlg.FileName))
                {
                    _bmpBck = (Bitmap)Image.FromFile(dlg.FileName);
                    toolStripButtonLoadLevel.Enabled = true;
                    panelLevel.Invalidate();
                }
            }
        }

        private void toolStripButtonSaveLevel_Click(object sender, EventArgs e)
        {
            SaveLevel();
        }

        private void toolStripButtonLoadLevel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "dat files (*.dat)|*.dat";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dlg.FileName))
                {
                    _sLevelFile = dlg.FileName;
                    LoadLevel();
                    panelLevel.Invalidate();
                }
            }
        }

        private void SaveLevel()
        {
            StreamWriter sw = new StreamWriter( _sLevelFile, false, Encoding.ASCII);

            sw.WriteLine(_iLevelFileVersion);
            sw.WriteLine(_iCurrentLevel);
            sw.WriteLine("--Walls--");
            sw.WriteLine(_iNumWalls);
            for (int i = 0; i < _iNumWalls; i++)
            {
                string wallType = _Objects[i].GetType().Name.Substring(4); // Remove "Wall" from the start
                sw.WriteLine(wallType);
                switch (wallType)
                {
                    case "Arc":
                        {
                            WallArc obj = _Objects[i] as WallArc;
                            sw.WriteLine("(" + obj._Centre.X + "," + obj._Centre.Y + ")," + obj._fRadius + ",(" + 
                                         obj._iStartAngle + "," + obj._iEndAngle + ")," + obj._bRemovable);
                        }
                        break;
                    case "Box":
                        {
                            WallBox obj = _Objects[i] as WallBox;
                            sw.WriteLine("(" + obj.MyRect.X + "," + obj.MyRect.Y + "," + obj.MyRect.Width + "," + obj.MyRect.Height + ")," + 
                                         obj._bBounceOffCorners + ",(" + obj.MoveableX + "," + obj.MoveableY + ")," + obj._bRemovable);
                        }
                        break;
                    case "Horizontal":
                        {
                            WallHorizontal obj = _Objects[i] as WallHorizontal;
                            sw.WriteLine("(" + obj.Left + "," + obj.Right + "," + obj.Y + "),(" + obj._bFiniteStart + "," + obj._bFiniteEnd + ")," + obj._bRemovable);
                        }
                        break;
                    case "Straight":
                        {
                            WallStraight obj = _Objects[i] as WallStraight;
                            sw.WriteLine("(" + obj.Start.X + "," + obj.Start.Y + "," + obj.End.X + "," + obj.End.Y + ")," + obj._bRemovable);
                        }
                        break;
                    case "Vertical":
                        {
                            WallVertical obj = _Objects[i] as WallVertical;
                            sw.WriteLine("(" + obj.Top + "," + obj.Bottom + "," + obj.X + "),(" + obj._bFiniteStart + "," + obj._bFiniteEnd + ")," + obj._bRemovable);
                        }
                        break;
                    case "Parabola":
                        {
                            WallParabola obj = _Objects[i] as WallParabola;
                            sw.WriteLine("(" + obj._Bounds.X + "," + obj._Bounds.Y + "," + obj._Bounds.Width + "," + obj._Bounds.Height + ")," +
                                         obj._bRemovable);
                        }
                        break;
                }
            }
            sw.WriteLine("--Balls--");
            sw.WriteLine(_iTotalNumBalls);
            sw.WriteLine(_iNumBallSets);
            for (int i = 0; i < _iNumBallSets; i++)
            {
                BallSet obj = _Objects[i + _iNumWalls] as BallSet;
                sw.WriteLine("Rnd"); // TODO: Add different types of ball sets as well as "Rnd".
                sw.WriteLine(obj.NumInSet);
                sw.WriteLine("(" + obj._rectBounds.X + "," + obj._rectBounds.Y + "," + obj._rectBounds.Width + "," + obj._rectBounds.Height + ")," +
                             obj._fVelrange + "," + obj._fRadius + ",(" + obj._Gravity.X + "," + obj._Gravity.Y + "),(" +
                             + obj._Colour.R + "," + obj._Colour.G + "," + obj._Colour.B + ")");
            }

            sw.Close();
        }

        private void LoadLevel()
        {
            StreamReader sr = new StreamReader(_sLevelFile, Encoding.ASCII);

            string line;
            _iLevelFileVersion = int.Parse(sr.ReadLine()); // File version
            _iCurrentLevel = int.Parse(sr.ReadLine());
            // Walls
            line = sr.ReadLine(); // "Walls"
            line = sr.ReadLine(); // Number of walls
            int.TryParse(line, out _iNumWalls);
            WallBase[] walls = new WallBase[_iNumWalls];
            string wallType;
            string[] wallParameters;
            float w = _rectBounds.Width;
            float h = _rectBounds.Height;
            float x = _rectBounds.X;
            float y = _rectBounds.Y;
            RectangleF r;
            for (int i = 0; i < _iNumWalls; i++)
            {
                wallType = sr.ReadLine(); // Type of wall
                wallParameters = ReadParameters(sr.ReadLine());
                switch (wallType)
                {
                    case "Arc":
                        walls[i] = new WallArc(new Vect2(double.Parse(wallParameters[0]), double.Parse(wallParameters[1])),
                                                double.Parse(wallParameters[2]), int.Parse(wallParameters[3]), int.Parse(wallParameters[4]),
                                                bool.Parse(wallParameters[5]));
                        break;
                    case "Box":
                        r = new RectangleF(float.Parse(wallParameters[0]), float.Parse(wallParameters[1]),
                                           float.Parse(wallParameters[2]), float.Parse(wallParameters[3]));
                        walls[i] = new WallBox(r, bool.Parse(wallParameters[4]), bool.Parse(wallParameters[5]),
                                                   bool.Parse(wallParameters[6]), bool.Parse(wallParameters[7]));
                        break;
                    case "Horizontal":
                        walls[i] = new WallHorizontal(double.Parse(wallParameters[0]), double.Parse(wallParameters[1]), double.Parse(wallParameters[2]),
                                                       bool.Parse(wallParameters[3]), bool.Parse(wallParameters[4]), bool.Parse(wallParameters[5]));
                        break;
                    case "Straight":
                        walls[i] = new WallStraight(new Vect2(double.Parse(wallParameters[0]), double.Parse(wallParameters[1])),
                                                     new Vect2(double.Parse(wallParameters[2]), double.Parse(wallParameters[3])),
                                                     bool.Parse(wallParameters[4]));
                        break;
                    case "Vertical":
                        walls[i] = new WallVertical(double.Parse(wallParameters[0]), double.Parse(wallParameters[1]), double.Parse(wallParameters[2]),
                                                     bool.Parse(wallParameters[3]), bool.Parse(wallParameters[4]), bool.Parse(wallParameters[5]));
                        break;
                    case "Parabola":
                        r = new RectangleF(float.Parse(wallParameters[0]), float.Parse(wallParameters[1]),
                                           float.Parse(wallParameters[2]), float.Parse(wallParameters[3]));
                        walls[i] = new WallParabola(r, bool.Parse(wallParameters[4]));
                        break;
                }
            }

            // Balls
            line = sr.ReadLine(); // "Balls"
            _iTotalNumBalls = int.Parse(sr.ReadLine()); // Total number of balls
            _iNumBallSets = int.Parse(sr.ReadLine()); // Number of sets of balls
            BallSet[] ballSets = new BallSet[_iNumBallSets];
            int iNumBallsInSet, iFirstBallInSet = 0;
            string ballSetType;
            string[] ballSetParameters;
            double velrange, radius;
            Vect2 gravity;
            Color colour;
            for (int i = 0; i < _iNumBallSets; i++)
            {
                ballSetType = sr.ReadLine(); // Type of ball set
                iNumBallsInSet = int.Parse(sr.ReadLine()); // Number of balls in this set
                ballSetParameters = ReadParameters(sr.ReadLine());
                ballSets[i] = null;
                switch (ballSetType)
                {
                    case "Rnd":
                        RectangleF bounds = new RectangleF(float.Parse(ballSetParameters[0]), float.Parse(ballSetParameters[1]),
                                                           float.Parse(ballSetParameters[2]), float.Parse(ballSetParameters[3]));
                        velrange = double.Parse(ballSetParameters[4]);
                        radius = double.Parse(ballSetParameters[5]);
                        gravity = new Vect2(double.Parse(ballSetParameters[6]), double.Parse(ballSetParameters[7]));
                        colour = Color.FromArgb(int.Parse(ballSetParameters[8]), int.Parse(ballSetParameters[9]), int.Parse(ballSetParameters[10]));
                        ballSets[i] = new BallSet(BallSetType.Rnd, iNumBallsInSet, bounds, velrange, radius, gravity, colour);
                        break;
                }
                iFirstBallInSet += iNumBallsInSet;
            }

            sr.Close();

            _iNumObjects = _iNumWalls + _iNumBallSets;
            _Objects = new ObjBase[_iNumObjects];
            int o = 0;
            if (walls != null)
            {
                foreach (WallBase wall in walls)
                {
                    _Objects[o++] = wall;
                }
            }

            if (ballSets != null)
            {
                foreach (BallSet ballSet in ballSets)
                {
                    _Objects[o++] = ballSet;
                }
            }
            UpdateControls();
        }

        private void UpdateControls()
        {
            textBoxLevelNum.Text = _iCurrentLevel.ToString();
            textBoxNumObjs.Text = _iNumObjects.ToString();
            textBoxNumWalls.Text = _iNumWalls.ToString();
            textBoxNumBallSets.Text = _iNumBallSets.ToString();
            textBoxTotalNumBalls.Text = _iTotalNumBalls.ToString();
            Text = "Demon Maxwell Game Level Creator - Level: " + _sLevelFile;
            numericUpDownObjSel.Maximum = _iNumObjects - 1;
        }

        private string[] ReadParameters(string line)
        {
            string lineCleaned = line.Replace("(", "").Replace(")", "");
            return lineCleaned.Split(',');
        }

        private void toolStripDropDownButtonAddWall_Click(object sender, EventArgs e)
        {

        }

        private void panelLevel_Paint(object sender, PaintEventArgs e)
        {
            if (_bmpBck == null)
                return;

            int w = panelLevel.ClientRectangle.Width;
            int h = w * _bmpBck.Height / _bmpBck.Width;
            int x = 0;
            int y = (panelLevel.ClientRectangle.Height - h) / 2;
            if (h > panelLevel.ClientRectangle.Height)
            {
                h = panelLevel.ClientRectangle.Height;
                w = h * _bmpBck.Width / _bmpBck.Height;
                y = 0;
                x = (panelLevel.ClientRectangle.Width - w) / 2;
            }
            _rectBounds = new Rectangle(x, y, w, h);
            e.Graphics.DrawImage(_bmpBck, _rectBounds);

            int i = 0;
            if (_Objects != null)
            {
                foreach (ObjBase obj in _Objects)
                {
                    obj.Draw(e.Graphics, i == _iObjSelected);
                    i++;
                }
            }
        }

        private void panelLevel_SizeChanged(object sender, EventArgs e)
        {
            panelLevel.Invalidate();
        }

        private void textBoxLevelNum_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (int.TryParse(textBoxLevelNum.Text, out val) && val > 0 && val <= 100)
            {
                _iCurrentLevel = val;
            }
        }

        private void numericUpDownObjSel_ValueChanged(object sender, EventArgs e)
        {
            _iObjSelected = (int)numericUpDownObjSel.Value;
            panelLevel.Invalidate();
            UpdateObjectParamsGroupBoxes();
        }

        private void UpdateObjectParamsGroupBoxes()
        {
            if (_Objects == null)
                return;
            groupBoxHorz.Visible = false;
            groupBoxVert.Visible = false;
            groupBoxStraight.Visible = false;
            groupBoxBox.Visible = false;
            groupBoxArc.Visible = false;
            groupBoxParabola.Visible = false;
            groupBoxBallSet.Visible = false;
            // TODO
            buttonSnapToNearest.Visible = false;
            if (_iObjSelected >= 0)
            {
                string type = _Objects[_iObjSelected].GetType().Name;
                switch(type)
                {
                    case "WallHorizontal":
                        UpdateWallHorzControls(_Objects[_iObjSelected] as WallHorizontal);
                        groupBoxHorz.Visible = true;
                        buttonSnapToNearest.Visible = true;
                        break;
                    case "WallVertical":
                        UpdateWallVertControls(_Objects[_iObjSelected] as WallVertical);
                        groupBoxVert.Visible = true;
                        buttonSnapToNearest.Visible = true;
                        break;
                    case "WallStraight":
                        UpdateWallStraightControls(_Objects[_iObjSelected] as WallStraight);
                        groupBoxStraight.Visible = true;
                        buttonSnapToNearest.Visible = true;
                        break;
                    case "WallBox":
                        UpdateWallBoxControls(_Objects[_iObjSelected] as WallBox);
                        groupBoxBox.Visible = true;
                        break;
                    case "WallArc":
                        UpdateWallArcControls(_Objects[_iObjSelected] as WallArc);
                        groupBoxArc.Visible = true;
                        break;
                    case "WallParabola":
                        UpdateWallParabolaControls(_Objects[_iObjSelected] as WallParabola);
                        groupBoxParabola.Visible = true;
                        break;
                    case "BallSet":
                        UpdateBallSetControls(_Objects[_iObjSelected] as BallSet);
                        groupBoxBallSet.Visible = true;
                        break;
                        // TODO
                }
            }
        }

        ///////////////////////////////////////////
        // Controls for individual types of objects
        //

        ///////////////////////////////////////////
        //
        // Wall - Horizontal
        //

        private void UpdateWallHorzControls(WallHorizontal obj)
        {
            textBoxHorzLeft.Text = obj.Left.ToString();
            textBoxHorzRight.Text = obj.Right.ToString();
            textBoxHorzY.Text = obj.Y.ToString();
            checkBoxHorzFiniteStart.Checked = obj._bFiniteStart;
            checkBoxHorzFiniteEnd.Checked = obj._bFiniteEnd;
            checkBoxHorzRemovable.Checked = obj._bRemovable;
        }

        private void textBoxHorzLeft_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallHorizontal obj = (WallHorizontal)_Objects[_iObjSelected];
            double val;
            if(double.TryParse(textBoxHorzLeft.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj.Left = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxHorzRight_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallHorizontal obj = (WallHorizontal)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxHorzRight.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj.Right = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxHorzY_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallHorizontal obj = (WallHorizontal)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxHorzY.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj.Y = val;
            }
            panelLevel.Invalidate();
        }

        private void checkBoxHorzFiniteStart_CheckedChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallHorizontal obj = (WallHorizontal)_Objects[_iObjSelected];
            obj._bFiniteStart = checkBoxHorzFiniteStart.Checked;
            panelLevel.Invalidate();
        }

        private void checkBoxHorzFiniteEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallHorizontal obj = (WallHorizontal)_Objects[_iObjSelected];
            obj._bFiniteEnd = checkBoxHorzFiniteEnd.Checked;
            panelLevel.Invalidate();
        }

        private void checkBoxHorzRemovable_CheckedChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallHorizontal obj = (WallHorizontal)_Objects[_iObjSelected];
            obj._bRemovable = checkBoxHorzRemovable.Checked;
            panelLevel.Invalidate();
        }

        ///////////////////////////////////////////
        //
        // Wall - Vertical
        //

        private void UpdateWallVertControls(WallVertical obj)
        {
            textBoxVertTop.Text = obj.Top.ToString();
            textBoxVertBot.Text = obj.Bottom.ToString();
            textBoxVertX.Text = obj.X.ToString();
            checkBoxVertFiniteStart.Checked = obj._bFiniteStart;
            checkBoxVertFiniteEnd.Checked = obj._bFiniteEnd;
            checkBoxVertRemovable.Checked = obj._bRemovable;
        }

        private void textBoxVertTop_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallVertical obj = (WallVertical)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxVertTop.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj.Top = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxVertBot_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallVertical obj = (WallVertical)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxVertBot.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj.Bottom = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxVertX_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallVertical obj = (WallVertical)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxVertX.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj.X = val;
            }
            panelLevel.Invalidate();
        }

        private void checkBoxVertFiniteStart_CheckedChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallVertical obj = (WallVertical)_Objects[_iObjSelected];
            obj._bFiniteStart = checkBoxVertFiniteStart.Checked;
            panelLevel.Invalidate();
        }

        private void checkBoxVertFiniteEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallVertical obj = (WallVertical)_Objects[_iObjSelected];
            obj._bFiniteEnd = checkBoxVertFiniteEnd.Checked;
            panelLevel.Invalidate();
        }

        private void checkBoxVertRemovable_CheckedChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallVertical obj = (WallVertical)_Objects[_iObjSelected];
            obj._bRemovable = checkBoxVertRemovable.Checked;
            panelLevel.Invalidate();
        }

        ///////////////////////////////////////////
        //
        // Wall - Straight
        //

        private void UpdateWallStraightControls(WallStraight obj)
        {
            textBoxStraightStartX.Text = obj.Start.X.ToString();
            textBoxStraightStartY.Text = obj.Start.Y.ToString();
            textBoxStraightEndX.Text = obj.End.X.ToString();
            textBoxStraightEndY.Text = obj.End.Y.ToString();
            checkBoxStraightRemovable.Checked = obj._bRemovable;
        }

        private void textBoxStraightStartX_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallStraight obj = (WallStraight)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxStraightStartX.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj._Start.X = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxStraightStartY_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallStraight obj = (WallStraight)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxStraightStartY.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj._Start.Y = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxStraightEndX_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallStraight obj = (WallStraight)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxStraightEndX.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj._End.X = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxStraightEndY_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallStraight obj = (WallStraight)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxStraightEndY.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj._End.Y = val;
            }
            panelLevel.Invalidate();
        }

        private void checkBoxStraightRemovable_CheckedChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallStraight obj = (WallStraight)_Objects[_iObjSelected];
            obj._bRemovable = checkBoxStraightRemovable.Checked;
            panelLevel.Invalidate();
        }

        ///////////////////////////////////////////
        //
        // Wall - Box
        //

        private void UpdateWallBoxControls(WallBox obj)
        {
            textBoxBoxX.Text = obj.MyRect.X.ToString();
            textBoxBoxY.Text = obj.MyRect.Y.ToString();
            textBoxBoxWidth.Text = obj.MyRect.Width.ToString();
            textBoxBoxHeight.Text = obj.MyRect.Height.ToString();
            checkBoxBoxMoveableX.Checked = obj.MoveableX;
            checkBoxBoxMoveableY.Checked = obj.MoveableY;
            checkBoxBoxBounceCorners.Checked = obj._bBounceOffCorners;
            checkBoxBoxRemovable.Checked = obj._bRemovable;
        }

        private void textBoxBoxX_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallBox obj = (WallBox)_Objects[_iObjSelected];
            float val;
            if (float.TryParse(textBoxBoxX.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj.MyRect.X = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxBoxY_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallBox obj = (WallBox)_Objects[_iObjSelected];
            float val;
            if (float.TryParse(textBoxBoxY.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj.MyRect.Y = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxBoxWidth_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallBox obj = (WallBox)_Objects[_iObjSelected];
            float val;
            if (float.TryParse(textBoxBoxWidth.Text, out val) && val > 0.0 && val <= 1.0)
            {
                obj.MyRect.Width = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxBoxHeight_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallBox obj = (WallBox)_Objects[_iObjSelected];
            float val;
            if (float.TryParse(textBoxBoxHeight.Text, out val) && val > 0.0 && val <= 1.0)
            {
                obj.MyRect.Height = val;
            }
            panelLevel.Invalidate();
        }

        private void checkBoxBoxMoveableX_CheckedChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallBox obj = (WallBox)_Objects[_iObjSelected];
            obj.MoveableX = checkBoxBoxMoveableX.Checked;
            panelLevel.Invalidate();
        }

        private void checkBoxBoxMoveableY_CheckedChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallBox obj = (WallBox)_Objects[_iObjSelected];
            obj.MoveableY = checkBoxBoxMoveableY.Checked;
            panelLevel.Invalidate();
        }

        private void checkBoxBoxBounceCorners_CheckedChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallBox obj = (WallBox)_Objects[_iObjSelected];
            obj._bBounceOffCorners = checkBoxBoxBounceCorners.Checked;
            panelLevel.Invalidate();
        }

        private void checkBoxBoxRemovable_CheckedChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallBox obj = (WallBox)_Objects[_iObjSelected];
            obj._bRemovable = checkBoxBoxRemovable.Checked;
            panelLevel.Invalidate();
        }

        ///////////////////////////////////////////
        //
        // Wall - Arc
        //

        private void UpdateWallArcControls(WallArc obj)
        {
            textBoxArcCentreX.Text = obj._Centre.X.ToString();
            textBoxArcCentreY.Text = obj._Centre.Y.ToString();
            textBoxArcRadius.Text = obj._fRadius.ToString();
            textBoxArcAngleFrom.Text = obj._iStartAngle.ToString();
            textBoxArcAngleTo.Text = obj._iEndAngle.ToString();
            checkBoxArcRemovable.Checked = obj._bRemovable;
        }

        private void textBoxArcCentreX_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallArc obj = (WallArc)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxArcCentreX.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj._Centre.X = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxArcCentreY_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallArc obj = (WallArc)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxArcCentreY.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj._Centre.Y = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxArcRadius_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallArc obj = (WallArc)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxArcRadius.Text, out val) && val > 0.0 && val < 10.0)
            {
                obj._fRadius = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxArcAngleFrom_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallArc obj = (WallArc)_Objects[_iObjSelected];
            int val;
            if (int.TryParse(textBoxArcAngleFrom.Text, out val) && val >= 0 && val < 360)
            {
                obj._iStartAngle = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxArcAngleTo_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallArc obj = (WallArc)_Objects[_iObjSelected];
            int val;
            if (int.TryParse(textBoxArcAngleTo.Text, out val) && val >= 0 && val < 360)
            {
                obj._iEndAngle = val;
            }
            panelLevel.Invalidate();
        }

        private void checkBoxArcRemovable_CheckedChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallArc obj = (WallArc)_Objects[_iObjSelected];
            obj._bRemovable = checkBoxArcRemovable.Checked;
            panelLevel.Invalidate();
        }

        ///////////////////////////////////////////
        //
        // Wall - Parabola
        //

        private void UpdateWallParabolaControls(WallParabola obj)
        {
            textBoxParabolaX.Text = obj._Bounds.X.ToString();
            textBoxParabolaY.Text = obj._Bounds.Y.ToString();
            textBoxParabolaWidth.Text = obj._Bounds.Width.ToString();
            textBoxParabolaHeight.Text = obj._Bounds.Height.ToString();
            checkBoxParabolaRemovable.Checked = obj._bRemovable;
        }

        private void textBoxParabolaX_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallParabola obj = (WallParabola)_Objects[_iObjSelected];
            float val;
            if (float.TryParse(textBoxParabolaX.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj._Bounds.X = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxParabolaY_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallParabola obj = (WallParabola)_Objects[_iObjSelected];
            float val;
            if (float.TryParse(textBoxParabolaY.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj._Bounds.Y = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxParabolaWidth_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallParabola obj = (WallParabola)_Objects[_iObjSelected];
            float val;
            if (float.TryParse(textBoxParabolaWidth.Text, out val) && val > 0.0 && val <= 1.0)
            {
                obj._Bounds.Width = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxParabolaHeight_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallParabola obj = (WallParabola)_Objects[_iObjSelected];
            float val;
            if (float.TryParse(textBoxParabolaHeight.Text, out val) && val > 0.0 && val <= 1.0)
            {
                obj._Bounds.Height = val;
            }
            panelLevel.Invalidate();
        }

        private void checkBoxParabolaRemovable_CheckedChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            WallParabola obj = (WallParabola)_Objects[_iObjSelected];
            obj._bRemovable = checkBoxParabolaRemovable.Checked;
            panelLevel.Invalidate();
        }

        ///////////////////////////////////////////
        //
        // Ball Set
        //

        private void UpdateBallSetControls(BallSet obj)
        {
            textBoxBallSetNumBalls.Text = obj.NumInSet.ToString();
            textBoxBallSetX.Text = obj._rectBounds.X.ToString();
            textBoxBallSetY.Text = obj._rectBounds.Y.ToString();
            textBoxBallSetWid.Text = obj._rectBounds.Width.ToString();
            textBoxBallSetHei.Text = obj._rectBounds.Height.ToString();
            textBoxBallSetVelRange.Text = obj._fVelrange.ToString();
            textBoxBallSetRadius.Text = obj._fRadius.ToString();
            textBoxBallSetGravityX.Text = obj._Gravity.X.ToString();
            textBoxBallSetGravityY.Text = obj._Gravity.Y.ToString();
            textBoxBallSetColR.Text = obj._Colour.R.ToString();
            textBoxBallSetColG.Text = obj._Colour.G.ToString();
            textBoxBallSetColB.Text = obj._Colour.B.ToString();
        }

        private void textBoxBallSetNumBalls_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            BallSet obj = (BallSet)_Objects[_iObjSelected];
            int val;
            if (int.TryParse(textBoxBallSetNumBalls.Text, out val) && val > 0 && val <= 1000000)
            {
                _iTotalNumBalls += (val - obj.NumInSet);
                obj.NumInSet = val;

            }
            panelLevel.Invalidate();
        }

        private void textBoxBallSetX_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            BallSet obj = (BallSet)_Objects[_iObjSelected];
            float val;
            if (float.TryParse(textBoxBallSetX.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj._rectBounds.X = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxBallSetY_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            BallSet obj = (BallSet)_Objects[_iObjSelected];
            float val;
            if (float.TryParse(textBoxBallSetY.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj._rectBounds.Y = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxBallSetWid_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            BallSet obj = (BallSet)_Objects[_iObjSelected];
            float val;
            if (float.TryParse(textBoxBallSetWid.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj._rectBounds.Width = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxBallSetHei_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            BallSet obj = (BallSet)_Objects[_iObjSelected];
            float val;
            if (float.TryParse(textBoxBallSetHei.Text, out val) && val >= 0.0 && val <= 1.0)
            {
                obj._rectBounds.Height = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxBallSetVelRange_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            BallSet obj = (BallSet)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxBallSetVelRange.Text, out val) && val >= 0.0 && val <= 10.0)
            {
                obj._fVelrange = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxBallSetRadius_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            BallSet obj = (BallSet)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxBallSetRadius.Text, out val) && val >= 0.0 && val <= 10.0)
            {
                obj._fRadius = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxBallSetGravityX_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            BallSet obj = (BallSet)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxBallSetGravityX.Text, out val) && val >= 0.0 && val <= 10.0)
            {
                obj._Gravity.X = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxBallSetGravityY_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            BallSet obj = (BallSet)_Objects[_iObjSelected];
            double val;
            if (double.TryParse(textBoxBallSetGravityY.Text, out val) && val >= 0.0 && val <= 10.0)
            {
                obj._Gravity.Y = val;
            }
            panelLevel.Invalidate();
        }

        private void textBoxBallSetColR_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            BallSet obj = (BallSet)_Objects[_iObjSelected];
            byte val;
            if (byte.TryParse(textBoxBallSetColR.Text, out val))
            {
                obj._Colour = Color.FromArgb(val, obj._Colour.G, obj._Colour.B);
            }
            panelLevel.Invalidate();
        }

        private void textBoxBallSetColG_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            BallSet obj = (BallSet)_Objects[_iObjSelected];
            byte val;
            if (byte.TryParse(textBoxBallSetColG.Text, out val))
            {
                obj._Colour = Color.FromArgb(obj._Colour.R, val, obj._Colour.B);
            }
            panelLevel.Invalidate();
        }

        private void textBoxBallSetColB_TextChanged(object sender, EventArgs e)
        {
            if (_iObjSelected < 0)
                return;
            BallSet obj = (BallSet)_Objects[_iObjSelected];
            byte val;
            if (byte.TryParse(textBoxBallSetColB.Text, out val))
            {
                obj._Colour = Color.FromArgb(obj._Colour.R, obj._Colour.G, val);
            }
            panelLevel.Invalidate();
        }

        ///////////////////////////////////////////
        //
        // Adding new objects
        //

        private void InsertWall(WallBase obj)
        {
            ObjBase[] newObjects = new ObjBase[_iNumObjects + 1];
            for(int i = 0; i < _iNumWalls; i++)
            {
                newObjects[i] = _Objects[i];
            }
            newObjects[_iNumWalls] = obj;
            _iObjSelected = _iNumWalls;
            for (int i = _iNumWalls; i < _iNumObjects; i++)
            {
                newObjects[i + 1] = _Objects[i];
            }
            _iNumWalls++;
            _iNumObjects++;
            _Objects = newObjects;
            panelLevel.Invalidate();
            UpdateControls();
            UpdateObjectParamsGroupBoxes();
        }

        private void InsertBallSet(BallSet obj)
        {
            ObjBase[] newObjects = new ObjBase[_iNumObjects + 1];
            for (int i = 0; i < _iNumObjects; i++)
            {
                newObjects[i] = _Objects[i];
            }
            newObjects[_iNumObjects] = obj;
            _iObjSelected = _iNumObjects;
            _iTotalNumBalls += obj.NumInSet;
            _iNumBallSets++;
            _iNumObjects++;
            _Objects = newObjects;
            panelLevel.Invalidate();
            UpdateControls();
            UpdateObjectParamsGroupBoxes();
        }

        private void toolStripMenuItemArc_Click(object sender, EventArgs e)
        {
            WallArc obj = new WallArc(new Vect2(0.5, 0.5), 0.4, 0, 90, false);
            InsertWall(obj);
        }

        private void toolStripMenuItemHorz_Click(object sender, EventArgs e)
        {
            WallHorizontal obj = new WallHorizontal(0.1, 0.9, 0.5, true, true, false);
            InsertWall(obj);
        }

        private void toolStripMenuItemVert_Click(object sender, EventArgs e)
        {
            WallVertical obj = new WallVertical(0.1, 0.9, 0.5, true, true, false);
            InsertWall(obj);
        }

        private void toolStripMenuItemStraight_Click(object sender, EventArgs e)
        {
            WallStraight obj = new WallStraight(new Vect2(0.1, 0.1), new Vect2(0.9, 0.9), false);
            InsertWall(obj);
        }

        private void toolStripMenuItemBox_Click(object sender, EventArgs e)
        {
            WallBox obj = new WallBox(new RectangleF(0.1f, 0.1f, 0.8f, 0.8f), true, false, false, false);
            InsertWall(obj);
        }

        private void toolStripMenuItemParabola_Click(object sender, EventArgs e)
        {
            WallParabola obj = new WallParabola(new RectangleF(0.1f, 0.1f, 0.8f, 0.8f), false);
            InsertWall(obj);
        }

        private void toolStripButtonAddBalls_Click(object sender, EventArgs e)
        {
            BallSet obj = new BallSet(BallSetType.Rnd, 100, new RectangleF(0.1f, 0.1f, 0.8f, 0.8f), 0.02, 0.02, new Vect2(0.0, 0.0), Color.Red);
            InsertBallSet(obj);
        }

        private void panelLevel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_bmpBck == null)
                return;
            double x = (double)(e.X - _rectBounds.X) / (double)_rectBounds.Width;
            double y = (double)(e.Y - _rectBounds.Y) / (double)_rectBounds.Height;
            if (x >= 0.0 && y >= 0.0 && x <= 1.0 && y <= 1.0)
            {
                labelCoords.Text = x.ToString("#.0000") + ", " + y.ToString("#.0000");
                Cursor.Current = Cursors.Cross;
            }
            else
            {
                labelCoords.Text = "--, --";
                Cursor.Current = Cursors.Default;
            }
        }

        private void buttonSnapToNearest_Click(object sender, EventArgs e)
        {
            if (_Objects == null)
                return;
            if (_iObjSelected >= 0)
            {
                string type = _Objects[_iObjSelected].GetType().Name;
                switch (type)
                {
                    case "Horizontal":
                        {
                            WallHorizontal obj = _Objects[_iObjSelected] as WallHorizontal;
                        }
                        break;
                    case "Straight":
                        {
                            WallStraight obj = _Objects[_iObjSelected] as WallStraight;
                        }
                        break;
                    case "Vertical":
                        {
                            WallVertical obj = _Objects[_iObjSelected] as WallVertical;
                        }
                        break;
                }
                panelLevel.Invalidate();
                UpdateControls();
                UpdateObjectParamsGroupBoxes();
            }
        }
    }
}
