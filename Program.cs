using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductHierarchy
{
    abstract class Products
    {
        public string CompanyName { get; set; } = "МАГАЗИН";
        public string ProductCategory { get; set; }
        public string ProductName { get; set; }
        public  Products (string ProductCategory, string ProductName)
        {
            this.ProductCategory = ProductCategory;
           this.ProductName = ProductName;
        }
        public abstract void GoodsArrived();
        public abstract void GoodsSold();
        public abstract void DiscardedGoods();
        public abstract void TransferredGoods();
    }

    abstract class Food : Products
    {
        public string FoodClassification { get; set; }
        public Food(string ProductName,string FoodClassification ) : base("еда", ProductName)
        {
            this.FoodClassification = FoodClassification;
        }

    }

    abstract class HouseholdСhemicals : Products
    {
        public string Purpose { get; set; }
        public bool Safety { get; set; }
        public HouseholdСhemicals(string ProductName, string Purpose, bool Safety) : base("бытовая химия", ProductName)
        {
            this.Safety =Safety; 
            this.Purpose = Purpose;
        }

    }

    class Bleach : HouseholdСhemicals
    {
        public string Country { get; set; }
        public Bleach(string ProductName,  string Country ) : base(ProductName, "отбеливатель для одежды", false)
        {
            this.Country = Country;
        }

        public override void DiscardedGoods()
        {
            if (Safety == true)
                Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " списано " + ProductName + ".\nНазначение " + ProductName + ": " + Purpose +". Безопасен!");
                      else
                Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " списано " + ProductName + ".\nНазначение " + ProductName + ": " + Purpose + ". Опасен!");
            Console.WriteLine("Страна происхождения: "+ Country);
        }

        public override void GoodsArrived()
        {
            if (Safety == true)
                Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " прибыли " + ProductName + ".\nНазначение " + ProductName + ": " + Purpose + ". Безопасен!");
            else
                Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " прибыли " + ProductName + ".\nНазначение " + ProductName + ": " + Purpose + ". Опасен!");
            Console.WriteLine("Страна происхождения: " + Country);
        }

        public override void GoodsSold()
        {
            Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " реализлвано " + ProductName);
            Console.WriteLine("Страна происхождения: " + Country);
        }

        public override void TransferredGoods()
        {
            Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " перпедано " + ProductName);
            Console.WriteLine("Страна происхождения: " + Country);
        }
    }

    class Polish : HouseholdСhemicals
    {
        public string Сolor { get; set; }
        public Polish(string ProductName,  string color) : base(ProductName, "полироль для мебели", true)
        {
            this.Сolor = color;
        }

        public override void DiscardedGoods()
        {
            if (Safety == true)
                Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " списано " + ProductName + ".\nНазначение " + ProductName + ": " + Purpose + ". Безопасен!");
            else
                Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " списано " + ProductName + ".\nНазначение " + ProductName + ": " + Purpose + ". Опасен!");
            Console.WriteLine("Цвет: " + Сolor);
        }

        public override void GoodsArrived()
        {
            if (Safety == true)
                Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " прибыли " + ProductName + ".\nНазначение " + ProductName + ": " + Purpose + ". Безопасен!");
            else
                Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " прибыли " + ProductName + ".\nНазначение " + ProductName + ": " + Purpose + ". Опасен!");
            Console.WriteLine("Цвет: " + Сolor);
        }

        public override void GoodsSold()
        {
            Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " реализлвано " + ProductName);
            Console.WriteLine("Цвет: " + Сolor);
        }

        public override void TransferredGoods()
        {
            Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " перпедано " + ProductName);
            Console.WriteLine("Цвет: " + Сolor);
        }
    }



    class Fruit : Food 
    {
        bool Fresh;
        public Fruit(string ProductName, bool fresh) : base(ProductName, "фрукты") {
            Fresh = fresh;
        }

        public override void DiscardedGoods()
        {
            if(Fresh==true)
            Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " списано " + ProductName+".\n"+ ProductName + " были свежие.");
            else
                Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " списано " + ProductName + ".\n" + ProductName + " были несвежие.");

        }

        public override void GoodsArrived()
        {
            if (Fresh == true)
                Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " прибыли " + ProductName + ".\n" + ProductName + " еще свежие.");
            else
                Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " прибыли " + ProductName + ".\n" + ProductName + " уже несвежие.");
        }

        public override void GoodsSold()
        {
            Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " реализлвано " + ProductName);
        }

        public override void TransferredGoods()
        {
            Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " перпедано " + ProductName);
        }
    }


    class MilkProducts : Food
    {
        int FatContent;
        public MilkProducts(string ProductName, int fet) : base(ProductName, "молочная продукция")
        {
            FatContent = fet;
        }

        public override void DiscardedGoods()
        {
          
                Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " списано " + ProductName + ".\nЖирность "  + FatContent +"%");
          

        }

        public override void GoodsArrived()
        {
         
                Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " списано " + ProductName + ".\nЖирность "  + FatContent + "%");
           
        }

        public override void GoodsSold()
        {
            Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " реализлвано " + ProductName+".\nЖирность " + FatContent + "%");
        }

        public override void TransferredGoods()
        {
            Console.WriteLine("В " + CompanyName + " из категории " + ProductCategory + " перпедано " + ProductName+".\nЖирность "  + FatContent + "%");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Products[] A = {new Fruit("яблоки", true), new Fruit("груши",false),   new MilkProducts("молоко", 20), new MilkProducts("сыр", 20),
            new Bleach("Vanish",  "Польша"), new Bleach("OXT",  "Украина"), new Polish ("BBT", "прозрачный"), new Polish ("VTV", "черный") };
            foreach(var t in A)
            {
                Console.WriteLine();
                t.GoodsArrived();
                t.GoodsSold();
                t.DiscardedGoods();
                t.TransferredGoods();
                
            }
            Console.ReadLine();
        }
    }
}
