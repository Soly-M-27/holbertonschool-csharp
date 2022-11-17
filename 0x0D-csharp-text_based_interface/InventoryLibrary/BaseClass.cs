using System;

namespace InventoryLibrary
{
    /// <summary>
    /// BaseClass Base
    /// </summary>
    public class BaseClass
    {
        private string id { get; set; }
        private DateTime date_created { get; set; }
        private DateTime date_updated { get; set; }

        /// <summary>
        /// BaseClass Constructor
        /// </summary>
        /// <param name="id">id to be created</param>
        /// <param name="date_created">date of creation</param>
        /// <param name="date_updated">updated date</param>
        /// <returns></returns>
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
}