using MongoDB.Driver;

// MongoDB sample: typed collection, filtered query, no SQL strings.
public class OrdersRepository
{
    private readonly IMongoCollection<OrderDoc> _col;
    public OrdersRepository(IMongoDatabase db) => _col = db.GetCollection<OrderDoc>("orders");
    public Task<List<OrderDoc>> PaidAsync() => _col.Find(o => o.Paid).ToListAsync();
}
public class OrderDoc { public string Id { get; set; } = ""; public decimal Total { get; set; } public bool Paid { get; set; } }
