using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodev.Forms.Setup
{
    public partial class Loyaltysetup : Form
    {
        public Loyaltysetup()
        {
            InitializeComponent();

            clsUtility.ExecuteSQLQuery("SELECT * FROM loyaltypoints");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                pointvalue.Text = clsUtility.sqlDT.Rows[0]["pointvalue"].ToString();
                //    amout1.Text = clsUtility.sqlDT.Rows[0]["amout1"].ToString();
                //    amout2.Text = clsUtility.sqlDT.Rows[0]["amout2"].ToString();
                //    amout3.Text = clsUtility.sqlDT.Rows[0]["amout3"].ToString();
                //    amout4.Text = clsUtility.sqlDT.Rows[0]["amout4"].ToString();
                //    amout5.Text = clsUtility.sqlDT.Rows[0]["amout5"].ToString();
                //    amout6.Text = clsUtility.sqlDT.Rows[0]["amout6"].ToString();
                //    amout7.Text = clsUtility.sqlDT.Rows[0]["amout7"].ToString();
                //    amout8.Text = clsUtility.sqlDT.Rows[0]["amout8"].ToString();
                //    amout9.Text = clsUtility.sqlDT.Rows[0]["amout9"].ToString();
                //    amout10.Text = clsUtility.sqlDT.Rows[0]["amout10"].ToString();

                //    points1.Text = clsUtility.sqlDT.Rows[0]["points1"].ToString();
                //    points2.Text = clsUtility.sqlDT.Rows[0]["points2"].ToString();
                //    points3.Text = clsUtility.sqlDT.Rows[0]["points3"].ToString();
                //    points4.Text = clsUtility.sqlDT.Rows[0]["points4"].ToString();
                //    points5.Text = clsUtility.sqlDT.Rows[0]["points5"].ToString();
                //    points6.Text = clsUtility.sqlDT.Rows[0]["points6"].ToString();
                //    points7.Text = clsUtility.sqlDT.Rows[0]["points7"].ToString();
                //    points8.Text = clsUtility.sqlDT.Rows[0]["points8"].ToString();
                //    points9.Text = clsUtility.sqlDT.Rows[0]["points9"].ToString();
                //    points10.Text = clsUtility.sqlDT.Rows[0]["points10"].ToString();

            }
            else
            {
                pointvalue.Text = "1";
                //    amout1.Text = "0";
                //    amout2.Text = "0";
                //    amout3.Text = "0";
                //    amout4.Text = "0";
                //    amout5.Text = "0";
                //    amout6.Text = "0";
                //    amout7.Text = "0";
                //    amout8.Text = "0";
                //    amout9.Text = "0";
                //    amout10.Text = "0";

                //    points1.Text = "0";
                //    points2.Text = "0";
                //    points3.Text = "0";
                //    points4.Text = "0";
                //    points5.Text = "0";
                //    points6.Text = "0";
                //    points7.Text = "0";
                //    points8.Text = "0";
                //    points9.Text = "0";
                //    points10.Text = "0";


                }
            }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clsUtility.ExecuteSQLQuery(" SELECT  * FROM   Users  WHERE   USER_ID = '" + clsUtility.UserID + "' AND   Can_Edit = 'Y' ");
            if (clsUtility.sqlDT.Rows.Count > 0)
            {
                ///////////////////////////////////////////  
                ///
        
                clsUtility.ExecuteSQLQuery("SELECT * FROM loyaltypoints");
                int amount1=0;
                int amount2=0;
                int amount3=0;
                int amount4=0;
                int amount5=0;
                int amount6=0;
                int amount7=0;
                int amount8=0;
                int amount9=0;
                int amount10=0;
                int point1=0;
                int point2=0;
                int point3=0;
                int point4=0;
                int point5=0;
                int point6=0;
                int point7=0;
                int point8=0;
                int point9=0;
                int point10=0;

                IDictionary<int, int> pointsset = new Dictionary<int, int>();
                if (!string.IsNullOrEmpty(amout1.Text) && !(pointsset.ContainsKey(Convert.ToInt32(amout1.Text))))
                {
                    pointsset.Add(Convert.ToInt32(amout1.Text), Convert.ToInt32(points1.Text));
                }
                if (!string.IsNullOrEmpty(amout2.Text) && !(pointsset.ContainsKey(Convert.ToInt32(amout2.Text))))
                {
                    pointsset.Add(Convert.ToInt32(amout2.Text), Convert.ToInt32(points2.Text));
                }
                if (!string.IsNullOrEmpty(amout3.Text) && !(pointsset.ContainsKey(Convert.ToInt32(amout3.Text))))
                {
                    pointsset.Add(Convert.ToInt32(amout3.Text), Convert.ToInt32(points3.Text));
                }
                if (!string.IsNullOrEmpty(amout4.Text) && !(pointsset.ContainsKey(Convert.ToInt32(amout4.Text))))
                {
                    pointsset.Add(Convert.ToInt32(amout4.Text), Convert.ToInt32(points4.Text));
                }
                if (!string.IsNullOrEmpty(amout5.Text) && !(pointsset.ContainsKey(Convert.ToInt32(amout5.Text))))
                {
                    pointsset.Add(Convert.ToInt32(amout5.Text), Convert.ToInt32(points5.Text));
                }
                if (!string.IsNullOrEmpty(amout6.Text) && !(pointsset.ContainsKey(Convert.ToInt32(amout6.Text))))
                {
                    pointsset.Add(Convert.ToInt32(amout6.Text), Convert.ToInt32(points6.Text));
                }
                if (!string.IsNullOrEmpty(amout7.Text) && !(pointsset.ContainsKey(Convert.ToInt32(amout7.Text))))
                {
                    pointsset.Add(Convert.ToInt32(amout7.Text), Convert.ToInt32(points7.Text));
                }
                if (!string.IsNullOrEmpty(amout8.Text) && !(pointsset.ContainsKey(Convert.ToInt32(amout8.Text))))
                {
                    pointsset.Add(Convert.ToInt32(amout8.Text), Convert.ToInt32(points8.Text));
                }
                if (!string.IsNullOrEmpty(amout9.Text) && !(pointsset.ContainsKey(Convert.ToInt32(amout9.Text))))
                {
                    pointsset.Add(Convert.ToInt32(amout9.Text), Convert.ToInt32(points9.Text));
                }
                if (!string.IsNullOrEmpty(amout10.Text) && !(pointsset.ContainsKey(Convert.ToInt32(amout10.Text))))
                {
                    pointsset.Add(Convert.ToInt32(amout10.Text), Convert.ToInt32(points10.Text));
                }

                int i = 1;
                foreach (var item in pointsset.OrderByDescending(x => x.Key))
                {
                        if (i == 1)
                        {
                            if (item.Key != 0)
                            { 
                                amount1 = item.Key;
                                point1 = item.Value;
                            }
                        }
                        if (i == 2)
                        {
                            if (item.Key != 0)
                            {
                                amount2 = item.Key;
                                point2 = item.Value;
                            }
                        }
                        if (i == 3)
                        {
                            if (item.Key != 0)
                            {
                                amount3 = item.Key;
                                point3 = item.Value;
                            }
                        }
                        if (i == 4)
                        {
                            if (item.Key != 0)
                            {
                                amount4 = item.Key;
                                point4 = item.Value;
                            }
                        }
                        if (i == 5)
                        {
                            if (item.Key != 0)
                            {
                                amount5 = item.Key;
                                point5 = item.Value;
                            }
                        }
                        if (i == 6)
                        {
                            if (item.Key != 0)
                            {
                                amount6 = item.Key;
                                point6 = item.Value;
                            }
                        }
                        if (i == 7)
                        {
                            if (item.Key != 0)
                            {
                                amount7 = item.Key;
                                point7 = item.Value;
                            }
                        }
                        if (i == 8)
                        {
                            if (item.Key != 0)
                            {
                                amount8 = item.Key;
                                point8 = item.Value;
                            }
                        }
                        if (i == 9)
                        {
                            if (item.Key != 0)
                            {
                                amount9 = item.Key;
                                point9 = item.Value;
                            }
                        }
                        if (i == 10)
                        {
                            if (item.Key != 0)
                            {
                                amount10 = item.Key;
                                point10 = item.Value;
                            }
                        }
                    i++;

                }

                if (clsUtility.sqlDT.Rows.Count > 0)
                    {
                        try
                        {
                        string Id = clsUtility.sqlDT.Rows[0]["Id"].ToString();
                        clsUtility.ExecuteSQLQuery(" DELETE FROM  loyaltypoints  WHERE Id ='" + Id + "'  ");
                        clsUtility.ExecuteSQLQuery(" INSERT INTO loyaltypoints (amout1,amout2,amout3,amout4,amout5,amout6,amout7,amout8,amout9,amout10,points1,points2,points3,points4,points5,points6,points7,points8,points9,points10,pointvalue) VALUES   ('" + amount1 + "','" + amount2 + "','" + amount3 + "','" + amount4 + "','" + amount5 + "','" + amount6 + "','" + amount7 + "','" + amount8 + "','" + amount9 + "','" + amount10 + "','" + point1 + "','" + point2 + "','" + point3 + "','" + point4 + "','" + point5 + "','" + point6 + "','" + point7 + "','" + point8 + "','" + point9 + "','" + point10 + "','" + pointvalue.Text + "') ");
                        clsUtility.MesgBoxShow("msgUpdate", "info");
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message); }
                    }
                    else
                    {
                        try
                        {
                        clsUtility.ExecuteSQLQuery(" INSERT INTO loyaltypoints (amout1,amout2,amout3,amout4,amout5,amout6,amout7,amout8,amout9,amout10,points1,points2,points3,points4,points5,points6,points7,points8,points9,points10,pointvalue) VALUES  ('" + amount1 + "','" + amount2 + "','" + amount3 + "','" + amount4 + "','" + amount5 + "','" + amount6 + "','" + amount7 + "','" + amount8 + "','" + amount9 + "','" + amount10 + "','" + point1 + "','" + point2 + "','" + point3 + "','" + point4 + "','" + point5 + "','" + point6 + "','" + point7 + "','" + point8 + "','" + point9 + "','" + point10 + "','" + pointvalue.Text + "') ");
                        clsUtility.MesgBoxShow("msgSaved", "info");
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message); }
                    }
                
                ///////////////////////////////////////////
            }
            else
            {
                clsUtility.MesgBoxShow("msgPermission", "err");
            }
        }
    }
}
