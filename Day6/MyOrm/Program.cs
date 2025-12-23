using Demo_CustomAttributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Demo_MyORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asmPath = @"C:\Users\IET\Desktop\.Net\Day6\Demo_EmpLib\bin\Debug\net8.0\Demo_EmpLib.dll";
                              

Assembly asm = Assembly.LoadFrom(asmPath);
            Type[] allTypes = asm.GetTypes();
            for (int i = 0; i < allTypes.Length; i++)
            {
                Type type = allTypes[i]; //Emp

                string createTableQuery = "CREATE TABLE ";

                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();

                for (int j = 0; j < allAttributes.Length; j++)
                {
                    Attribute attr = allAttributes[j];
                    if (attr is Demo_CustomAttributes.TableAttribute)
                    {
                        Demo_CustomAttributes.TableAttribute tableAttr = attr as Demo_CustomAttributes.TableAttribute;
                        createTableQuery = createTableQuery + tableAttr.TableName + " ( ";
                        // CREATE TABLE Employee ( 
                    }
                }


                PropertyInfo[] allPeroperties = type.GetProperties();

                for (int k = 0; k < allPeroperties.Length; k++)
                {
                    PropertyInfo prop = allPeroperties[k];
                    Attribute[] propAttr = prop.GetCustomAttributes().ToArray();

                    for (int l = 0; l < propAttr.Length; l++)
                    {
                        Attribute pAttr = propAttr[l];
                        if (pAttr is Demo_CustomAttributes.ColumnAttribute)
                        {
                            Demo_CustomAttributes.ColumnAttribute col = pAttr as Demo_CustomAttributes.ColumnAttribute;
                            // CREATE TABLE Employee ( 
                            createTableQuery = createTableQuery + col.ColumnName + " " + col.ColumnType + ",";
                        }
                        // CREATE TABLE Employee ( EId int, EName varchar(50), EAddress varchar(50) )
                    }
                }
                createTableQuery = createTableQuery.TrimEnd(',') + " )";
                Console.WriteLine(createTableQuery);

                string filePath = @"C:\Users\IET\Desktop\.Net\Day6\MyOrm\SQLQuery\CreateTableQueries.sql";

                File.WriteAllText(filePath, createTableQuery);

                Console.WriteLine("Done.");
            }
        }
    }
}
