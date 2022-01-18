using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu1, fExit = 1;
            int tmpType;
            int tmpId;
            int tmpPrice;
            string tmpName;
            do
            {
                while (true)
                {
                    try
                    {
                        Console.Clear();
                        OleDbConnection myConnection = new OleDbConnection();
                        myConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=HDD1.mdb;";
                        myConnection.Open();
                        string query = "SELECT hdd_id, hdd_name, hdd_storage, hdd_price FROM HDD ORDER BY hdd_id";
                        OleDbCommand command = new OleDbCommand(query, myConnection);
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine("Id: {0}, Name: {1}, storage: {2}, price: {3}", reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                        }
                        reader.Close();
                        myConnection.Close();
                        Console.WriteLine();
                        Console.WriteLine("1. Добавить");
                        Console.WriteLine("2. Изменить");
                        Console.WriteLine("3. Удалить");
                        Console.WriteLine("4. Выход");
                        menu1 = int.Parse(Console.ReadLine());
                        switch (menu1)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Укажите наименование: ");
                                    tmpName = Console.ReadLine();
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Укажите № склада: ");
                                            tmpType = Convert.ToInt32(Console.ReadLine());
                                            break;
                                        }
                                        catch (Exception exc)
                                        {
                                            Console.WriteLine("Ошибка ввода:\n" + exc.Message);
                                        }
                                    }
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Укажите цену: ");
                                            tmpPrice = Convert.ToInt32(Console.ReadLine());
                                            break;
                                        }
                                        catch (Exception exc)
                                        {
                                            Console.WriteLine("Ошибка ввода:\n" + exc.Message);
                                        }
                                    }
                                    myConnection.Open();
                                    string queryAdd = "INSERT INTO HDD (hdd_name, hdd_storage, hdd_price) VALUES ('" + tmpName + "', " + tmpType + ", " + tmpPrice + " )";
                                    command = new OleDbCommand(queryAdd, myConnection);
                                    command.ExecuteNonQuery();
                                    myConnection.Close();
                                    Console.WriteLine("Добавлено");
                                    Console.ReadKey();
                                }
                                break;
                            case 2:
                                {
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Укажите id для изменения данных:");
                                            tmpId = Convert.ToInt32(Console.ReadLine());
                                            break;
                                        }
                                        catch (Exception exc)
                                        {
                                            Console.WriteLine("Ошибка ввода:\n" + exc.Message);
                                        }
                                    }
                                    myConnection.Open();
                                    command = new OleDbCommand("Select * from HDD WHERE hdd_id like '%" + tmpId + "%'", myConnection);
                                    OleDbDataReader reader1 = command.ExecuteReader();
                                    if (reader1.Read())
                                    {
                                        reader.Close();
                                        myConnection.Close();
                                        Console.WriteLine("Укажите новое наименование: ");
                                        tmpName = Console.ReadLine();
                                        while (true)
                                        {
                                            try
                                            {
                                                Console.WriteLine("Укажите новую цену: ");
                                                tmpPrice = Convert.ToInt32(Console.ReadLine());
                                                break;
                                            }
                                            catch (Exception exc)
                                            {
                                                Console.WriteLine("Ошибка ввода:\n" + exc.Message);
                                            }
                                        }
                                        myConnection.Open();
                                        string queryUp = "UPDATE HDD SET hdd_name = '" + tmpName + "', hdd_price = '" + tmpPrice + "'  WHERE hdd_id = " + tmpId + "";
                                        command = new OleDbCommand(queryUp, myConnection);
                                        command.ExecuteNonQuery();
                                        myConnection.Close();
                                        Console.WriteLine("Изменено");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Под id = {0} не найдено товара", tmpId);
                                        Console.ReadKey();
                                    }

                                    Console.WriteLine();
                                }
                                break;
                            case 3:
                                {
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Укажите id для удаления данных:");
                                            tmpId = Convert.ToInt32(Console.ReadLine());
                                            break;
                                        }
                                        catch (Exception exc)
                                        {
                                            Console.WriteLine("Ошибка ввода:\n" + exc.Message);
                                        }
                                    }
                                    myConnection.Open();
                                    command = new OleDbCommand("Select * from HDD WHERE hdd_id like '%" + tmpId + "%'", myConnection);
                                    OleDbDataReader reader1 = command.ExecuteReader();
                                    if (reader1.Read())
                                    {
                                        reader.Close();
                                        myConnection.Close();
                                        myConnection.Open();
                                        string queryDel = "DELETE FROM HDD WHERE hdd_id = " + tmpId + "";
                                        command = new OleDbCommand(queryDel, myConnection);
                                        command.ExecuteNonQuery();
                                        myConnection.Close();
                                        Console.WriteLine("Удалено");
                                        Console.ReadKey();
                                    }
                                    else Console.WriteLine("Под id = {0} не найдено товара", tmpId);
                                    Console.ReadKey();
                                }
                                break;
                            case 4:
                                {
                                    fExit = 0;
                                }
                                break;
                            default:
                                Console.WriteLine("Не верный запрос");
                                Console.ReadKey();
                                break;
                        }
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine("Ошибка ввода:\n" + exc.Message);
                        Console.ReadKey();
                    }
                }
            } while (fExit == 1);
        }
    }
}
