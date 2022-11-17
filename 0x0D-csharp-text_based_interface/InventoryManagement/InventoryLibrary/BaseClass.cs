using System;

public class BaseClass
{
    private string id { get; set; }
    private DateTime date_created { get; set; }
    private DateTime date_updated { get; set; }

    public BaseClass(string id = null, DateTime date_created = default(DateTime), DateTime date_updated = default(DateTime))
    {
        if (id == null)
        {
            this.id = Guid.NewGuid().ToString();
        }
        else
        {
            this.id = id;
        }

        if (date_created == default(DateTime))
        {
            this.date_created = DateTime.Now;
        }
        else
        {
            this.date_created = date_created;
        }

        if (date_updated == default(DateTime))
        {
            this.date_updated = DateTime.Now;
        }
        else
        {
            this.date_updated = date_updated;
        }
    }

}