using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ProductTest();

//CategoryTest();

//GetProductDetailsTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

    var result = productManager.GetAll();

    if (result.Success)
    {
        foreach (var item in result.Data)
        {
            Console.WriteLine(item.ProductName);
        }

    }
    else
    {
        Console.WriteLine(result.Message);
    }

}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    foreach (var categories in categoryManager.GetAll().Data)
    {
        Console.WriteLine(categories.CategoryName);
    }
}

static void GetProductDetailsTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

    foreach (var getProductDetail in productManager.GetProductDetails().Data)
    {
        Console.WriteLine(getProductDetail.ProductName + " - " + getProductDetail.CategoryName);
    }
}