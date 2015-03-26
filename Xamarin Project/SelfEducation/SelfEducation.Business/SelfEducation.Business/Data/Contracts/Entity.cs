using SQLite.Net.Attributes;

namespace SelfEducation.Business.Data.Contracts
{
    public abstract class Entity : IEntity
    {
        /// <summary>
        /// Gets or sets the Database ID.
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}