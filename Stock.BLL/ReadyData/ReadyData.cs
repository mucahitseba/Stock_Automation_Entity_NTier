using Stock.BLL.Store;
using Stock.MODELS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BLL.ReadyData
{
    public class ReadyData
    {
        public void DataProduce()
        {
            if (new CategoryStore().GetAll().Any() || new ProductStore().GetAll().Any()) return;
            CategoryProduce();
            ProductProduce();
        }

        private void CategoryProduce()
        {
            Category category = null;
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    switch (i)
                    {
                        case 0:
                            category = new Category()
                            {
                                CategoryName = "Gıda Ürünleri",
                                Avails = (decimal)0.10,
                                KDV = (decimal)0.08
                            };
                            break;
                        case 1:
                            category = new Category()
                            {
                                CategoryName = "Temizlik Ürünleri",
                                Avails = (decimal)0.10,
                                KDV = (decimal)0.18
                            };
                            break;
                        case 2:
                            category = new Category()
                            {
                                CategoryName = "Elektronik",
                                Avails = (decimal)0.20,
                                KDV = (decimal)0.25
                            };
                            break;
                        case 3:
                            category = new Category()
                            {
                                CategoryName = "Süreli Yayınlar",
                                Avails = (decimal)0.15,
                                KDV = (decimal)0.08
                            };
                            break;
                        case 4:
                            category = new Category()
                            {
                                CategoryName = "Kırtasiye",
                                Avails = (decimal)0.20,
                                KDV = (decimal)0.18
                            };
                            break;
                        case 5:
                            category = new Category()
                            {
                                CategoryName = "Unlu Mamuller",
                                Avails = (decimal)0.15,
                                KDV = (decimal)0.01
                            };
                            break;
                        case 6:
                            category = new Category()
                            {
                                CategoryName = "Şarküteri",
                                Avails = (decimal)0.30,
                                KDV = (decimal)0.08
                            };
                            break;
                        case 7:
                            category = new Category()
                            {
                                CategoryName = "Kişisel Bakım",
                                Avails = (decimal)0.30,
                                KDV = (decimal)0.08
                            };
                            break;
                        case 8:
                            category = new Category()
                            {
                                CategoryName = "İçecekler",
                                Avails = (decimal)0.20,
                                KDV = (decimal)0.08
                            };
                            break;
                        case 9:
                            category = new Category()
                            {
                                CategoryName = "Giyim",
                                Avails = (decimal)0.30,
                                KDV = (decimal)0.18
                            };
                            break;

                        default:
                            break;
                    }
                    new CategoryStore().Insert(category);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ProductProduce()
        {
            Product product = null;
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    switch (i)
                    {
                        case 0:
                            product = new Product()
                            {
                                CategoryId = 1,
                                ProductName = "Ülker Çikolatalı Gofret",
                                UnitPrice = 0.90m,
                                PerBoxPiece = 200,
                                Discount = 0.05m,
                                ProductBarcode = "8690504016700",
                                Stock = 3000
                            };
                            break;
                        case 1:
                            product = new Product()
                            {
                                CategoryId = 1,
                                ProductName = "Ankara Burgu Makarna 500 gr",
                                UnitPrice = 1m,
                                PerBoxPiece = 150,
                                Discount = 0.00m,
                                ProductBarcode = "8690576029172",
                                Stock = 3000
                            };
                            break;
                        case 2:
                            product = new Product()
                            {
                                CategoryId = 2,
                                ProductName = "Cif Krem Limon Kokulu Yüzey Temizleyicisi 750 ml",
                                UnitPrice = 7m,
                                PerBoxPiece = 180,
                                Discount = 0.00m,
                                ProductBarcode = "8690637069840",
                                Stock = 3000
                            };
                            break;
                        case 3:
                            product = new Product()
                            {
                                CategoryId = 2,
                                ProductName = "Scotch-Brite 2'li Sünger",
                                UnitPrice = 1.2m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "8690734354764"
                            };
                            break;
                        case 4:
                            product = new Product()
                            {
                                CategoryId = 3,
                                ProductName = "Piranha Kablosuz Kulaklık",
                                UnitPrice = 30m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "8698720989471"
                            };
                            break;
                        case 5:
                            product = new Product()
                            {
                                CategoryId = 3,
                                ProductName = "Golyat 3'lü Priz",
                                UnitPrice = 20m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "8680304700442"
                            };
                            break;
                        case 6:
                            product = new Product()
                            {
                                CategoryId = 4,
                                ProductName = "Uykusuz",
                                UnitPrice = 4m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "9771307761178"
                            };
                            break;
                        case 7:
                            product = new Product()
                            {
                                CategoryId = 4,
                                ProductName = "Bilim Çocuk",
                                UnitPrice = 5m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "9771301746003"
                            };
                            break;
                        case 8:
                            product = new Product()
                            {
                                CategoryId = 5,
                                ProductName = "Faber Castell 6'lı Keçeli Kalem",
                                UnitPrice = 8m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "8690826232000"
                            };
                            break;
                        case 9:
                            product = new Product()
                            {
                                CategoryId = 5,
                                ProductName = "Mopak Defter 80 Sayfa",
                                UnitPrice = 2m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "8690830270135"
                            };
                            break;
                        case 10:
                            product = new Product()
                            {
                                CategoryId = 6,
                                ProductName = "Beyaz Ekmek",
                                UnitPrice = 0.90m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.0m,
                                ProductBarcode = "8695077001207"
                            };
                            break;
                        case 11:
                            product = new Product()
                            {
                                CategoryId = 6,
                                ProductName = "Uno Kruvasan",
                                UnitPrice = 5m,
                                Stock = 3000,
                                PerBoxPiece = 150,
                                Discount = 0.00m,
                                ProductBarcode = "8690698503642"
                            };
                            break;
                        case 12:
                            product = new Product()
                            {
                                CategoryId = 7,
                                ProductName = "Pınar Mangal Keyfi Sucuk",
                                UnitPrice = 15m,
                                Stock = 3000,
                                PerBoxPiece = 180,
                                Discount = 0.10m,
                                ProductBarcode = "8690527021088"
                            };
                            break;
                        case 13:
                            product = new Product()
                            {
                                CategoryId = 7,
                                ProductName = "Şenpiliç Bütün Tavuk",
                                UnitPrice = 13m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "8696415042623"
                            };
                            break;
                        case 14:
                            product = new Product()
                            {
                                CategoryId = 8,
                                ProductName = "Gillette Blue3 Yedek Tıraş Bıçağı 6'lı",
                                UnitPrice = 15m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "7702018037216"
                            };
                            break;
                        case 15:
                            product = new Product()
                            {
                                CategoryId = 8,
                                ProductName = "Nivea Krem 150 ml",
                                UnitPrice = 10m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "4005800001192"
                            };
                            break;
                        case 16:
                            product = new Product()
                            {
                                CategoryId = 9,
                                ProductName = "Le Cola 2,5 L",
                                UnitPrice = 2m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "8695077305220"
                            };
                            break;
                        case 17:
                            product = new Product()
                            {
                                CategoryId = 9,
                                ProductName = "Le Porta 2,5 L",
                                UnitPrice = 2m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "8695077305221"
                            };
                            break;
                        case 18:
                            product = new Product()
                            {
                                CategoryId = 10,
                                ProductName = "6'lı Yünlü Çorap",
                                UnitPrice = 12m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "8690826232001"
                            };
                            break;
                        case 19:
                            product = new Product()
                            {
                                CategoryId = 10,
                                ProductName = "Beyaz Erkek İçlik",
                                UnitPrice = 14m,
                                Stock = 3000,
                                PerBoxPiece = 200,
                                Discount = 0.00m,
                                ProductBarcode = "8690830270136"
                            };
                            break;

                        default:
                            break;
                    }
                    new ProductStore().Insert(product);
                    product = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        
    }
}
