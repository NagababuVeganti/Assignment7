using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_EF_Start.Models
{
  

public class Store
{

    [Key]
   [DatabaseGenerated(DatabaseGeneratedOption.None)]
   public int storeId {get; set;}
  public string storeName { get; set; }
  public List<Orders> orders {get;set;}
  public List<Products> products { get; set; }

}

public class Orders
{
  [Key]
 [DatabaseGenerated(DatabaseGeneratedOption.None)]
 public int OrderId {get;set;}
  public int OrderTotal {get; set;}
  
public string OrderTime { get; set; }
  public Store store { get; set; }

  public List<OrderProductMap> orderProducts {get;set;}
}


public class OrderProductMap
{

    public int Id { get; set; }
    public Orders order {get;set;}
   public Products product {get;set;}

   public int pquantity{get;set;}

}

public class Products
{
 [Key]
 [DatabaseGenerated(DatabaseGeneratedOption.None)]
 public int ProductId {get; set;}

  public string name {get;set;}
  public int cost {get;set;}
  public List<OrderProductMap> Productorders {get;set;}

  public Store store { get; set;}
}

}