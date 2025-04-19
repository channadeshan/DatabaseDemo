using System;
using System.Collections.Generic;

namespace WebStore.Entities;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? OrderStatus { get; set; }

    public int ShippingAddressId { get; set; }

    public int BillingAddressId { get; set; }

    public virtual Address BillingAddress { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Address ShippingAddress { get; set; } = null!;

    public int? CarrierId { get; set; } = null!;
    public string? TrackingNumber { get; set; } = null!;
    public DateTime? ShippedDate { get; set; } = null!;
    public DateTime? DeliveredDate { get; set; } = null!;

    public int? DiscountCodeId { get; set; }
    public DiscountCode? DiscountCode { get; set; }

    /// <summary>
    /// Navigation to the carrier (e.g. "UPS", "FedEx")
    /// </summary>
    public Carrier? Carrier { get; set; } = null!;
}
