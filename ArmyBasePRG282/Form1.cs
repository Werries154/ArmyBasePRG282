using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmyBasePRG282
{
    public partial class StartForm : Form
    {
        bool bremove = false;
        bool busy = false;
        List<PictureBox> EnemyBuildings = new List<PictureBox>();
        List<PictureBox> obstaclestoavoid = new List<PictureBox>();
        List<PictureBox> sniperobstacles = new List<PictureBox>();
        List<PictureBox> mgobstacles = new List<PictureBox>();
        List<PictureBox> tankobstacles = new List<PictureBox>();
        List<PictureBox> allobstacles = new List<PictureBox>();
        List<Plane> allplanes = new List<Plane>();
        Datahandler dh = new Datahandler();


        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            InitializePboxes();
            allplanes = dh.GetPlanes();
            foreach (Plane thisplane in allplanes)
            {
                MessageBox.Show(thisplane.ToString());
            }
            pbArmory.Visible = false;

        }


        private void InitializePboxes()
        {
            ControlExtension.Draggable(Scout1, true);
            ControlExtension.Draggable(AA1, true);
            ControlExtension.Draggable(AA2, true);
            ControlExtension.Draggable(MG1, true);
            ControlExtension.Draggable(MG2, true);
            ControlExtension.Draggable(MG3, true);
            ControlExtension.Draggable(Sniper1, true);
            ControlExtension.Draggable(Sniper2, true);
            ControlExtension.Draggable(Sniper3, true);
            ControlExtension.Draggable(Sniper4, true);
            ControlExtension.Draggable(Tank1, true);
            ControlExtension.Draggable(Tank2, true);
            ControlExtension.Draggable(Tank3, true);
            ControlExtension.Draggable(Tank4, true);
            ControlExtension.Draggable(Tank5, true);
            Scout1.Visible = false;
            AA1.Visible = false;
            AA2.Visible = false;
            MG1.Visible = false;
            MG2.Visible = false;
            MG3.Visible = false;
            Sniper1.Visible = false;
            Sniper2.Visible = false;
            Sniper3.Visible = false;
            Sniper4.Visible = false;
            Tank1.Visible = false;
            Tank2.Visible = false;
            Tank3.Visible = false;
            Tank4.Visible = false;
            Tank5.Visible = false;
            mgobstacles.Add(MG1);
            mgobstacles.Add(MG2);
            mgobstacles.Add(MG3);
            sniperobstacles.Add(Sniper1);
            sniperobstacles.Add(Sniper2);
            sniperobstacles.Add(Sniper3);
            sniperobstacles.Add(Sniper4);
            tankobstacles.Add(Tank1);
            tankobstacles.Add(Tank2);
            tankobstacles.Add(Tank3);
            tankobstacles.Add(Tank4);
            tankobstacles.Add(Tank5);
            allobstacles.Add(Scout1);
            allobstacles.Add(AA1);
            allobstacles.Add(AA2);
            allobstacles.Add(MG1);
            allobstacles.Add(MG2);
            allobstacles.Add(MG3);
            allobstacles.Add(Sniper1);
            allobstacles.Add(Sniper2);
            allobstacles.Add(Sniper3);
            allobstacles.Add(Sniper4);
            allobstacles.Add(Tank1);
            allobstacles.Add(Tank2);
            allobstacles.Add(Tank3);
            allobstacles.Add(Tank4);
            allobstacles.Add(Tank5);
            EnemyBuildings.Add(pbCommstower);
            EnemyBuildings.Add(pbHeadquarters);
            EnemyBuildings.Add(pbBarracks);
            EnemyBuildings.Add(pbMedbay);
            EnemyBuildings.Add(pbArmory);
            EnemyBuildings.Add(pbAircraftrunway);
            EnemyBuildings.Add(pbAircrafthangar);
            EnemyBuildings.Add(pbGym);
            EnemyBuildings.Add(pbVehiclebay);
            EnemyBuildings.Add(pbDiningarea);


        }

        private void addScoutTowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Scout1.Visible == false)
                {
                    Scout1.Visible = true;
                }
                else
                {
                    throw new CustomException("Only 1 scout can be placed at a time");
                    
                }
            }
            catch (CustomException ce)
            {

                MessageBox.Show(ce.Message, "Placement error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        private void RemoveObstacletoolStripMenuItem_Click(object sender, EventArgs e)
        {
            bremove = true;

        }

        private void Scout1_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                Scout1.Visible = false;
                bremove = false;
            }
        }

        private void MG1_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                MG1.Visible = false;
                bremove = false;
            }
        }

        private void MG2_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                MG2.Visible = false;
                bremove = false;
            }
        }

        private void MG3_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                MG3.Visible = false;
                bremove = false;
            }
        }

        private void Sniper1_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                Sniper1.Visible = false;
                bremove = false;
            }
        }

        private void Sniper2_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                Sniper2.Visible = false;
                bremove = false;
            }
        }

        private void Sniper3_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                Sniper3.Visible = false;
                bremove = false;
            }
        }

        private void Sniper4_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                Sniper4.Visible = false;
                bremove = false;
            }
        }

        private void Tank1_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                Tank1.Visible = false;
                bremove = false;
            }
        }

        private void Tank2_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                Tank2.Visible = false;
                bremove = false;
            }
        }

        private void AA1_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                AA1.Visible = false;
                bremove = false;
            }
        }

        private void Tank3_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                Tank3.Visible = false;
                bremove = false;
            }
        }

        private void AA2_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                AA2.Visible = false;
                bremove = false;
            }
        }

        private void Tank5_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                Tank5.Visible = false;
                bremove = false;
            }
        }

        private void Tank4_Click(object sender, EventArgs e)
        {
            if (bremove)
            {
                Tank4.Visible = false;
                bremove = false;
            }
        }

        private void addSniperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PictureBox> invisible = new List<PictureBox>();
            try
            {
                foreach (PictureBox pbinstance in sniperobstacles)
                {
                    if (!pbinstance.Visible)
                    {
                        invisible.Add(pbinstance);
                    }
                }
                if (invisible.Count != 0)
                {
                    invisible[0].Visible = true;
                }
                else
                {
                    throw new CustomException("Only 4 Sniper obstacles can be placed at a time");

                }
            }
            catch (CustomException ce)
            {

                MessageBox.Show(ce.Message, "Number of sniper obstacles to be placed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void addAAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AA1.Visible && !AA2.Visible)
                {
                    AA1.Visible = true;
                }
                else
                {

                    if (AA1.Visible && AA2.Visible)
                    {
                        throw new CustomException("Only 2 AA obstacles can be placed at a time");

                    }
                    if (AA1.Visible || AA2.Visible)
                    {
                        AA1.Visible = true;
                        AA2.Visible = true;
                    }

                }
            }
            catch (CustomException ce)
            {
                MessageBox.Show(ce.Message, "Number of AA obstacles to be placed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void addMGPitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PictureBox> invisible = new List<PictureBox>();
            try
            {
                foreach (PictureBox pbinstance in mgobstacles)
                {
                    if (!pbinstance.Visible)
                    {
                        invisible.Add(pbinstance);
                    }
                }
                if (invisible.Count != 0)
                {
                    invisible[0].Visible = true;
                }
                else
                {
                    throw new CustomException("Only 3 MG pit obstacles can be placed at a time");

                }
            }
            catch (CustomException ce)
            {

                MessageBox.Show(ce.Message, "Number of MG pit ostacles to be placed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void addA1AbrahamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PictureBox> invisible = new List<PictureBox>();
            try
            {
                foreach (PictureBox pbinstance in tankobstacles)
                {
                    if (!pbinstance.Visible)
                    {
                        invisible.Add(pbinstance);
                    }
                }
                if (invisible.Count != 0)
                {
                    invisible[0].Visible = true;
                }
                else
                {
                    throw new CustomException("Only 5 tank obstacles can be placed at a time");

                }
            }
            catch (CustomException ce)
            {

                MessageBox.Show(ce.Message, "Number of tank obsacles to be placed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void StartSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveNext();





        }

        private void pbPlane_Move(object sender, EventArgs e)
        {
            if (!busy)
            {
                foreach (PictureBox obstacle in obstaclestoavoid)
                {
                    if ((pbPlane.Right > obstacle.Left - 40 && pbPlane.Right < obstacle.Right + 40) && (pbPlane.Top > obstacle.Bottom - 40 && pbPlane.Top < obstacle.Top + 40))
                    {
                        busy = true;
                        for (int i = 0; i < Scout1.Height + pbPlane.Height; i++)
                        {
                            pbPlane.Top -= 1;
                        }
                        for (int j = 0; j < Scout1.Width + pbPlane.Width + 80; j++)
                        {
                            pbPlane.Left += 1;
                        }
                        busy = false;
                    }
                }
               
            }
        }
        private void MoveNext()
        {
            if (!busy) { 
            foreach (PictureBox pbinstance in allobstacles)
            {
                if (pbinstance.Visible)
                {
                    obstaclestoavoid.Add(pbinstance);
                }
            }
            foreach (PictureBox building in EnemyBuildings)
            {
                bool barrived = false;
                    while (!barrived)
                    {
                        if (pbPlane.Left > building.Left)
                        {
                            pbPlane.Left -= 1;
                        }
                        if (pbPlane.Left < building.Left)
                        {
                            pbPlane.Left += 1;
                        }
                        if (pbPlane.Top > building.Top)
                        {
                            pbPlane.Top -= 1;


                        }
                        if (pbPlane.Top < building.Top)
                        {

                            pbPlane.Top += 1;

                        }

                        if (pbPlane.Top == building.Top && pbPlane.Left == building.Left)
                        {
                            barrived = true;
                        }
                    }
                }
            }
        }

        private void f15JetcraftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbPlane.Image = ArmyBasePRG282.Properties.Resources.G4_supergaleb_let;
        }

        private void aC130GunshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbPlane.Image = ArmyBasePRG282.Properties.Resources.giphy;
        }

        private void mH53PaveLowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbPlane.Image = ArmyBasePRG282.Properties.Resources.japanese_fighter_bomber;
        }

        private void u2ReconPlaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbPlane.Image = ArmyBasePRG282.Properties.Resources.animated_aeroplane_image_0057;
        }

        private void b52ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbPlane.Image = ArmyBasePRG282.Properties.Resources.giphyv;
        }
    }
}




