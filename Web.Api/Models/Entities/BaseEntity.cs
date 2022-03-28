using System;
using Web.Api.Enums;

namespace Web.Api.Models.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime EditedDate { get; set; } = DateTime.Now;

        public long UpdatedBy { get; set; }

        public ItemState State { get; set; } = ItemState.Creted;

        public void Update(long userId)
        {
            EditedDate = DateTime.Now;
            UpdatedBy = userId;
            State = ItemState.Updated;
        }

        public void Delete(long userId)
        {
            EditedDate = DateTime.Now;
            UpdatedBy = userId;
            State = ItemState.Deleted;
        }
    }
}
