namespace Wagner.Domain
{
    public class ProjectResource
    {
        public int ProjectResourceId { get; set; }
        public Resource Resource { get; set; }
        public Project Project { get; set; }
        public Role Role { get; set; }
    }
}
