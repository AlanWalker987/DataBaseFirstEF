using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstEF
{
    public class Crud
    {
        public static void Main(string[] args)
        {
            int opt;
            int id;
            DataBaseEFEntities dataBaseEFEntities = new DataBaseEFEntities();
            Area areaObj = new Area(); 
            do
            {
                Console.WriteLine("1.New Record \n 2.Display \n 3.Update Record \n 4.Delete Record \n 5.Exit");
                Console.WriteLine("Enter the option");
                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1: Console.WriteLine("Enter AreaName, CityId and Pincode");
                        areaObj.AreaName = Console.ReadLine();
                        areaObj.AreaId = Convert.ToInt32(Console.ReadLine());
                        areaObj.Pincode = Console.ReadLine();

                        dataBaseEFEntities.Areas.Add(areaObj);
                        dataBaseEFEntities.SaveChanges();
                        break;
                    case 2:
                        foreach (Area a in dataBaseEFEntities.Areas)
                        {
                            Console.WriteLine("{0} \t {1} \t {2} \t {3} \t", a.AreaId, a.AreaName, a.Pincode, a.City.CityName);
                        }
                        break;
                    case 3:Console.WriteLine("Enter Id to update");
                        id = Convert.ToInt32(Console.ReadLine());

                        areaObj = dataBaseEFEntities.Areas.Find(id);
                        if(areaObj == null)
                        {
                            Console.WriteLine("Invalid Id");
                        }
                        else
                        {
                            Console.WriteLine("Enter AreaName, CityId and Pincode");
                            areaObj.AreaName = Console.ReadLine();
                            areaObj.AreaId = Convert.ToInt32(Console.ReadLine());
                            areaObj.Pincode = Console.ReadLine();
                            dataBaseEFEntities.SaveChanges();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Id to Delete");
                        id = Convert.ToInt32(Console.ReadLine());

                        areaObj = dataBaseEFEntities.Areas.Find(id);
                        if (areaObj == null)
                        {
                            Console.WriteLine("Invalid Id");
                        }
                        else
                        {
                            Console.WriteLine("Enter AreaName, CityId and Pincode");
                            areaObj.AreaName = Console.ReadLine();
                            areaObj.AreaId = Convert.ToInt32(Console.ReadLine());
                            areaObj.Pincode = Console.ReadLine();
                            dataBaseEFEntities.Areas.Remove(areaObj);
                            dataBaseEFEntities.SaveChanges();
                        }
                        break;
                    case 5:
                        break;
                    default: Console.WriteLine("Invalid Option");
                        break;
                }

            } while (opt != 0);

        }
       
    }
}
