using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThemeMoveListDemo;

namespace ThemeTussleMoveList
{
    public partial class Nina : Form
    {
        public Nina()
        {
            InitializeComponent();
        }

        int currentRecord = 0;
        int currentId = 0;
        int firstId = 0;
        int lastId = 0;
        int? previousId;
        int? nextId;

        private void Nina_Load(object sender, EventArgs e)
        {
            LoadFirstMove();
        }

        private void LoadFirstMove()
        {

            object moveId = DataAccess.GetValue("SELECT TOP (1) MoveId FROM Move WHERE CharacterId = 1");

            if (moveId == null)
            {
                NavigationState(false);
                return;
            }

            NavigationState(true);

            firstId = Convert.ToInt32(moveId);
            currentId = firstId;
            LoadMoveDetails();
            NextPreviousButtonManagement();

        }

        private void LoadMoveDetails()
        {
            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Move WHERE MoveId = {currentId} AND CharacterId = 1",
                $@"
                SELECT 
                (
                    SELECT TOP(1) MoveId as FirstId FROM Move WHERE CharacterId = 1
                ) as FirstId,
                q.PreviousId,
                q.NextId,
                (
                    SELECT TOP(1) MoveId as LastId FROM Move WHERE CharacterId = 1 ORDER BY MoveId Desc
                ) as LastId,
                q.RowNumber
                FROM
                (
                    SELECT MoveId,
                    LEAD(MoveId) OVER(ORDER BY MoveId) AS NextId,
                    LAG(MoveId) OVER(ORDER BY MoveId) AS PreviousId,
                    ROW_NUMBER() OVER(ORDER BY MoveId) AS 'RowNumber'
                    FROM Move WHERE CharacterId = 1
                ) AS q
                WHERE q.MoveId = {currentId}",
                 $"SELECT COUNT(MoveId) as MoveCount FROM Move WHERE CharacterId = 1"
            };

            try
            {
                DataSet ds = new DataSet();
                ds = DataAccess.GetData(sqlStatements);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow selectedMove = ds.Tables[0].Rows[0];

                    txtName.Text = selectedMove["InputName"].ToString();
                    txtDmg.Text = selectedMove["Damage"].ToString();
                    txtStartup.Text = selectedMove["StartupFrames"].ToString();
                    txtActive.Text = selectedMove["ActiveFrames"].ToString();
                    txtRecovery.Text = selectedMove["RecoveryFrames"].ToString();
                    txtBlock.Text = selectedMove["OnBlock"].ToString();
                    txtHitBoxSize.Text = selectedMove["HitBoxSize"].ToString();
                    txtHitBoxPos.Text = selectedMove["HitBoxPos"].ToString();
                    txtHurtBoxSize.Text = selectedMove["HurtBoxSize"].ToString();
                    txtHurtBoxPos.Text = selectedMove["HurtBoxPos"].ToString();
                    txtDesc.Text = selectedMove["Description"].ToString();

                    string moveImg = $"Nina{txtName.Text}";
                    charImg.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(moveImg);

                    firstId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstId"]);
                    previousId = ds.Tables[1].Rows[0]["PreviousId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousId"]) : (int?)null;
                    nextId = ds.Tables[1].Rows[0]["NextId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextId"]) : (int?)null;
                    lastId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastId"]);
                    currentRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);
                }
                else
                {
                    LoadFirstMove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        #region [Navigation Helpers]

        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousId != null;
            btnNext.Enabled = nextId != null;
        }

        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            switch (b.Name)
            {
                case "btnFirst":
                    currentId = firstId;
                    break;
                case "btnLast":
                    currentId = lastId;
                    break;
                case "btnPrevious":
                    currentId = previousId.Value;
                    break;
                case "btnNext":
                    currentId = nextId.Value;
                    break;
            }

            LoadMoveDetails();
            NextPreviousButtonManagement();
        }

        private void NavigationState(bool enableState)
        {
            btnFirst.Enabled = enableState;
            btnLast.Enabled = enableState;
            btnNext.Enabled = enableState;
            btnPrevious.Enabled = enableState;
        }

        #endregion

    }
}
