namespace Core.Entity
{
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }

        public string WorkTitle { get; set; }

        public string Email { get; set; }

        public string PictureUrl { get; set; }

        public string Description { get; set; }

        public string WorkExtension { get; set; }
    }
}