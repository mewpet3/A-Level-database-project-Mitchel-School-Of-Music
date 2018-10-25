using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitchell_School_of_Music
{
    public static class Utilities
    {
        //Ensures a string is valid in relation to the defined parameters.
        public static bool ValidString(string value, int min, int max)
        {
            try
            {
                //Checks to ensure passed string is within the defined parameters for length. Doing so will also check if the string entered is null, in either case, this will ensure the string is valid.
                if (value.Length >= min && value.Length <= max && !string.IsNullOrWhiteSpace(value))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        //Checks if entered value is a valid character (not null)
        public static bool ValidChar(char? value)
        {
            try
            {
                if (value != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        //checks if string entered is a single character
        public static bool ValidChar(string value)
        {
            try
            {
                char temp;
                return (char.TryParse(value, out temp));
            }
            catch
            {
                return false;
            }
        }

        //Ensures the integer entered is a valid number by ensuring it is within the defined parameters.
        public static bool ValidNumber(int? value, int maxValue, int minValue)
        {
            try
            {
                if (value <= maxValue && value >= minValue)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        //Overload of the valid integer so as double variables can also be checked to be valid in terms of the determined paramenters.
        public static bool ValidNumber(double? value, double maxValue, double minValue)
        {
            try
            {
                if (value <= maxValue && value >= minValue)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        //Overload of the valid integer so as float variables can also be checked to be valid in terms of the determined paramenters.
        public static bool ValidNumber(float? value, double maxValue, double minValue)
        {
            try
            {
                if (value <= maxValue && value >= minValue)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        //Ensures the date entered is valid by ensuring it can be parsed to a DateTime format as well as falling between the min and max parameters.
        public static bool ValidDate(string value, DateTime maxValue, DateTime minValue)
        {
            try
            {
                DateTime temp = DateTime.Parse(value);
                if (temp <= maxValue && temp >= minValue)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        //checks if string entered is a valid date
        public static bool ValidDate(string value)
        {
            try
            {
                DateTime.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Overload of the validate the date method (ValidDate) so as to validate the DateTime format rather than just the string to DateTime format.
        public static bool ValidDate(DateTime? value, DateTime maxValue, DateTime minvalue)
        {
            try
            {
                if (value.HasValue && value <= maxValue && value >= minvalue)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        //checks if entered date is null
        public static bool ValidDate(DateTime? value)
        {
            try
            {
                DateTime temp;
                return DateTime.TryParse(value.ToString(), out temp);
            }
            catch
            {
                return false;
            }
        }

        //checks if entered time is a valid time
        public static bool ValidTime(string Time)
        {
            try
            {
                if (int.Parse(Time.Substring(0,2)) < 24 && int.Parse(Time.Substring(0,2)) >= 0 && int.Parse(Time.Substring(3,2)) < 60 && int.Parse(Time.Substring(3, 2)) >= 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        //ensures that a bool is not null.
        public static bool ValidBool(bool? value)
        {
            try
            {
                if (value != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        //Checks if the string entered is a valid bool value
        public static bool ValidBool(string value)
        {
            try
            {
                bool.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Filters a string array so as only unique values are included
        public static string[] UniqueArrayData(string[] Values)
        {
            try
            {
                string[] UniqueArray = new string[Values.Length];
                UniqueArray = Values.Distinct().ToArray();
                return UniqueArray;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to convert array to distinct values.\r\n\r\nAdditional information:\r\n" + ex.Message);
            }
        }

        // performs a regex check to ensure the entered telno is a valid british telno.
        public static bool ValidTelNo(string value)
        {
            return Regex.IsMatch(value, @"^(((\+44\s?\d{4}|\(?0\d{4}\)?)\s?\d{3}\s?\d{3})|((\+44\s?\d{3}|\(?0\d{3}\)?)\s?\d{3}\s?\d{4})|((\+44\s?\d{2}|\(?0\d{2}\)?)\s?\d{4}\s?\d{4}))(\s?\#(\d{4}|\d{3}))?$");
        }

        // performs a regex check to ensure the entered postcode is a valid british postcode.
        public static bool ValidPostcode(string value)
        {
            return 
            (
                Regex.IsMatch(value, "(^[A-PR-UWYZa-pr-uwyz][0-9][ ]*[0-9][ABD-HJLNP-UW-Zabd-hjlnp-uw-z]{2}$)") ||
                Regex.IsMatch(value, "(^[A-PR-UWYZa-pr-uwyz][0-9][0-9][ ]*[0-9][ABD-HJLNP-UW-Zabd-hjlnp-uw-z]{2}$)") ||
                Regex.IsMatch(value, "(^[A-PR-UWYZa-pr-uwyz][A-HK-Ya-hk-y][0-9][ ]*[0-9][ABD-HJLNP-UW-Zabd-hjlnp-uw-z]{2}$)") ||
                Regex.IsMatch(value, "(^[A-PR-UWYZa-pr-uwyz][A-HK-Ya-hk-y][0-9][0-9][ ]*[0-9][ABD-HJLNP-UW-Zabd-hjlnp-uw-z]{2}$)") ||
                Regex.IsMatch(value, "(^[A-PR-UWYZa-pr-uwyz][0-9][A-HJKS-UWa-hjks-uw][ ]*[0-9][ABD-HJLNP-UW-Zabd-hjlnp-uw-z]{2}$)") ||
                Regex.IsMatch(value, "(^[A-PR-UWYZa-pr-uwyz][A-HK-Ya-hk-y][0-9][A-Za-z][ ]*[0-9][ABD-HJLNP-UW-Zabd-hjlnp-uw-z]{2}$)") ||
                Regex.IsMatch(value, "(^[Gg][Ii][Rr][]*0[Aa][Aa]$)")
            );
        }

        //provides a data view with a query of the entered data.
        public static DataView DataTableFilter(string table, string Column, string search, string priSort)
        {
            try
            {
                DataView dv;
                //checks if the requested column is a string datatype
                if (DataAccess.ds.Tables[table].Columns[Column].DataType == typeof(string))
                {
                    dv = new DataView(DataAccess.ds.Tables[table], Column + " Like '" + search + "%' ", priSort + " ASC", DataViewRowState.CurrentRows);
                    return dv;
                }
                //checks if the requested column is a int datatype
                else if (DataAccess.ds.Tables[table].Columns[Column].DataType == typeof(int))
                {
                    dv = new DataView(DataAccess.ds.Tables[table], Column + " = " + int.Parse(search), priSort + " ASC", DataViewRowState.CurrentRows);
                    return dv;
                }
                //checks if the requested column is a decimal datatype
                else if (DataAccess.ds.Tables[table].Columns[Column].DataType == typeof(decimal))
                {
                    dv = new DataView(DataAccess.ds.Tables[table], Column + " = " + decimal.Parse(search), priSort + " ASC", DataViewRowState.CurrentRows);
                    return dv;
                }
                //checks if the requested column is a bool datatype
                else if (DataAccess.ds.Tables[table].Columns[Column].DataType == typeof(bool))
                {
                    if (Utilities.ValidBool(search))
                    {
                        dv = new DataView(DataAccess.ds.Tables[table], Column + " = '" + bool.Parse(search) + "'", priSort + " ASC", DataViewRowState.CurrentRows);
                        return dv;
                    }
                    else
                    {
                        throw new Exception("Value entered is not a valid true or false value.");
                    }
                }
                //checks if the requested column is a DateTime datatype
                else if (DataAccess.ds.Tables[table].Columns[Column].DataType == typeof(DateTime))
                {
                    if (Utilities.ValidDate(search))
                    {
                        dv = new DataView(DataAccess.ds.Tables[table], Column + " = '" + DateTime.Parse(search) + "'", priSort + " ASC", DataViewRowState.CurrentRows);
                        return dv;
                    }
                    else
                    {
                        throw new Exception("Date entered is not a valid date.");
                    }
                }
                else
                {
                    throw new Exception("No type was matched, failed to filter.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error filtering data table. " + ex.Message);
            }
        }

        //Returns a string array of all items from a data column 
        public static string[] RetrieveItemsFromDataCollumn(DataTable dt, string CollumnName)
        {
            string[] values = new string[dt.Rows.Count];
            int temp = 0;
            foreach (DataRow dr in dt.Rows)
            {
                values[temp] = dr[CollumnName].ToString();
                temp++;
            }
            return values;
        }

        //method to quickly open a new form with the option to close the current one.
        public static void OpenNewForm(Form CurrentFormName, Form NewFormName, bool CloseCurrent)
        {
            NewFormName.Show();
            NewFormName.Location = CurrentFormName.Location;
            if (CloseCurrent)
                CurrentFormName.Close();
        }

        //Shutdown the application.
        public static void ShutDownApplication()
        {
            Application.Exit();
        }
    }
}