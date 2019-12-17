﻿using System;
using System.Collections.Generic;
using System.Text;

namespace APM.SL
{
  public class Discount
  {
    public int DiscountId { get; private set; }
    public string? DiscountName { get; set; }

    public decimal? PercentOff { get; set; }

    public decimal PercentOffOriginal { get; set; }


    // ... Discount details

    public Discount? FindDiscount(List<Discount>? discounts, string discountName)
    {
      if (discounts is null) return null;

      var foundDiscount = discounts.Find(d => d.DiscountName == discountName);

      return foundDiscount;
    }

    //public Discount FindDiscountWithException(List<Discount>? discounts, string discountName)
    //{
    //  if (discounts is null) throw new ArgumentException("No discounts to process");

    //  var foundDiscount = discounts.Find(d => d.DiscountName == discountName);

    //  if (foundDiscount is null) throw new DiscountNotFoundException("Discount not found");

    //  return foundDiscount;
    //}

    public (Discount? Discount, string? Message) FindDiscountWithTuple(List<Discount>? discounts, string discountName)
    {
      if (discounts is null)
        return (Discount: null, Message: "No discounts found");

      var foundDiscount =
                 discounts.Find(d => d.DiscountName == discountName);

      if (foundDiscount is null)
        return (Discount: null, Message: "Not found");

      return (Discount: foundDiscount, Message: null);
    }

  }
}
