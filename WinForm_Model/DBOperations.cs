using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WinForm_Model
{
    //class DBOperations
    //{
        
    
    //    public DataSet ExecuteNonQuery(string[] fieldName, string[] fieldValues, string spName)
    //    {
    //        SQLiteCommand cmd = null;
    //        DataBase cn = null;
    //        SQLiteDataAdapter da = null;
    //        DataSet ds = null;

    //        DataBaseVariable.IsSuccess = false;

    //        string[] dt;

    //        try
    //        {
    //            cn = new DataBase();

    //            cmd = new SQLiteCommand();
    //            cmd.Connection = cn.cn;
    //            cmd.CommandText = spName;
    //            cmd.CommandType = CommandType.StoredProcedure;

    //            for (int a = 0; a <= fieldName.Length - 1; a++)
    //            {
    //                if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   ." || fieldValues[a] == "." || fieldValues[a] == "  .")
    //                {
    //                    cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
    //                }
    //                else
    //                {
    //                    if (fieldName[a] == "a111" || fieldName[a] == "EntryDate" || fieldName[a] == "CreationDate"
    //                        )
    //                    {
    //                        if (fieldValues[a].ToString() == "01/01/0001" || fieldValues[a].ToString() == "  /  /")
    //                        {
    //                            cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
    //                        }
    //                        else
    //                        {
    //                            dt = fieldValues[a].Split('/');
    //                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
    //                        }
    //                    }
    //                    else
    //                    {
    //                        cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
    //                    }
    //                }
    //            }

    //            da = new SQLiteDataAdapter(cmd);
    //            ds = new DataSet();
    //            da.Fill(ds);

    //            DataBaseVariable.IsSuccess = true;
    //        }

    //        catch (Exception ex)
    //        {
    //            if (ex.Message == "String was not recognized as a valid DateTime.")
    //            {
    //                MessageBox.Show("Invalid Date format. Date must be entered in dd/mm/yyyy format ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            }
    //            else
    //            {
    //                MessageBox.Show(ex.Message);
    //            }
    //        }

    //        finally
    //        {
    //            cmd = null;
    //            cn = null;
    //        }

    //        return ds;
    //    }




    //    public bool Validate_Dictionary(string fldval, string spName, string criteria, string formno)
    //    {
    //        DataSet ds = null;
    //        bool IsError = false;

    //        try
    //        {
    //            string[] fldname = { "Criteria" };
    //            string[] fldvalue = { criteria };

    //            ds = ExecuteNonQuery(fldname, fldvalue, spName);

    //            if (formno == "")
    //            {
    //                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                IsError = true;
    //            }
    //            else
    //            {
    //                if (ds != null)
    //                {
    //                    if (ds.Tables.Count > 0)
    //                    {
    //                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value5"].ToString()) == false)
    //                        {
    //                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString() && formno != ds.Tables[0].Rows[0]["value4"].ToString() && formno != ds.Tables[0].Rows[0]["value5"].ToString())
    //                            {
    //                                if (formno.ToString().IndexOf('.') == -1)
    //                                {
    //                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
    //                                    {
    //                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
    //                                        {
    //                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                                            IsError = true;
    //                                        }
    //                                    }
    //                                }
    //                                else
    //                                {
    //                                    if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value4"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value5"]) == Convert.ToDouble(formno))
    //                                    {

    //                                    }
    //                                    else
    //                                    {
    //                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
    //                                        {
    //                                            if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
    //                                            {
    //                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                                                IsError = true;
    //                                            }
    //                                        }
    //                                    }
    //                                }
    //                            }
    //                        }
    //                        else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false)
    //                        {
    //                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString() && formno != ds.Tables[0].Rows[0]["value4"].ToString())
    //                            {
    //                                if (formno.ToString().IndexOf('.') == -1)
    //                                {
    //                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
    //                                    {
    //                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
    //                                        {
    //                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                                            IsError = true;
    //                                        }
    //                                    }
    //                                }
    //                                else
    //                                {
    //                                    if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value4"]) == Convert.ToDouble(formno))
    //                                    {

    //                                    }
    //                                    else
    //                                    {
    //                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
    //                                        {
    //                                            if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
    //                                            {
    //                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                                                IsError = true;
    //                                            }
    //                                        }
    //                                    }
    //                                }
    //                            }
    //                        }
    //                        else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false)
    //                        {
    //                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString())
    //                            {
    //                                if (formno.ToString().IndexOf('.') == -1)
    //                                {
    //                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
    //                                    {
    //                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
    //                                        {
    //                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                                            IsError = true;
    //                                        }
    //                                    }
    //                                }
    //                                else
    //                                {
    //                                    if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno))
    //                                    {

    //                                    }
    //                                    else
    //                                    {
    //                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
    //                                        {
    //                                            if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
    //                                            {
    //                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                                                IsError = true;
    //                                            }
    //                                        }
    //                                    }
    //                                }
    //                            }
    //                        }
    //                        else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false)
    //                        {
    //                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString())
    //                            {
    //                                if (formno.ToString().IndexOf('.') == -1)
    //                                {
    //                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
    //                                    {
    //                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
    //                                        {
    //                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                                            IsError = true;
    //                                        }
    //                                    }
    //                                }
    //                                else
    //                                {
    //                                    if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno))
    //                                    {

    //                                    }
    //                                    else
    //                                    {
    //                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
    //                                        {
    //                                            if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
    //                                            {
    //                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                                                IsError = true;
    //                                            }
    //                                        }
    //                                    }
    //                                }
    //                            }
    //                        }
    //                        else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false)
    //                        {
    //                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString())
    //                            {
    //                                if (formno.ToString().IndexOf('.') == -1)
    //                                {
    //                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
    //                                    {
    //                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
    //                                        {
    //                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                                            IsError = true;
    //                                        }
    //                                    }
    //                                }
    //                                else
    //                                {
    //                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
    //                                    {
    //                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
    //                                        {
    //                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                                            IsError = true;
    //                                        }
    //                                    }
    //                                }
    //                            }
    //                        }
    //                        else
    //                        {
    //                            if (formno.ToString().IndexOf('.') == -1)
    //                            {
    //                                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
    //                                {
    //                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
    //                                    {
    //                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                                        IsError = true;
    //                                    }
    //                                }
    //                            }
    //                            else
    //                            {
    //                                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
    //                                {
    //                                    if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
    //                                    {
    //                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                                        IsError = true;
    //                                    }
    //                                }
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //        }

    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        }

    //        finally
    //        {
    //            ds = null;
    //        }

    //        return IsError;
    //    }




    //    public DataSet GetFormData(string spName, string fldval, string formno)
    //    {
    //        DataSet ds = null;

    //        try
    //        {
    //            string[] fldname = { "FormID", "fldvalue" };
    //            string[] fldvalue = { formno, fldval };

    //            ds = ExecuteNonQuery(fldname, fldvalue, spName);
    //        }

    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        }

    //        finally
    //        {

    //        }

    //        return ds;
    //    }



    //    public DataSet GetFormData_VisitID(string spName, string fldval, string formno, string visitid)
    //    {
    //        DataSet ds = null;

    //        try
    //        {
    //            string[] fldname = { "FormID", "fldvalue", "visitid" };
    //            string[] fldvalue = { formno, fldval, visitid };

    //            ds = ExecuteNonQuery(fldname, fldvalue, spName);
    //        }

    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        }

    //        finally
    //        {

    //        }

    //        return ds;
    //    }



    //    public DataSet DeleteForm1(string FormID, string spName, string fldvalue, string visitid)
    //    {
    //        SQLiteCommand cmd = null;
    //        DataBase cn = null;
    //        SQLiteDataAdapter da = null;
    //        DataSet ds = null;
    //        SQLiteTransaction trans = null;

    //        try
    //        {
    //            cn = new DataBase();
    //            cn.MConnOpen();

    //            trans = cn.cn.BeginTransaction();

    //            cmd = new SQLiteCommand();
    //            cmd.Connection = cn.cn;
    //            cmd.CommandText = spName;
    //            cmd.Transaction = trans;
    //            cmd.CommandType = CommandType.StoredProcedure;

    //            if (FormID == "")
    //            {
    //                cmd.Parameters.AddWithValue("FormID", "NULL");
    //            }
    //            else
    //            {
    //                cmd.Parameters.AddWithValue("FormID", FormID);
    //            }


    //            cmd.Parameters.AddWithValue("fldvalue", fldvalue);
    //            cmd.Parameters.AddWithValue("visitid", visitid);


    //            da = new SQLiteDataAdapter(cmd);
    //            ds = new DataSet();
    //            da.Fill(ds);


    //            trans.Commit();
    //        }

    //        catch (Exception ex)
    //        {
    //            trans.Rollback();
    //            MessageBox.Show(ex.Message);
    //        }

    //        finally
    //        {
    //            cn.MConnClose();
    //            cmd = null;
    //            cn = null;
    //        }

    //        return ds;
    //    }




    //}
}

