namespace snake_v1.Infrastructure
{
    public interface IMap : IRigidBody, IMenuItem
    {
        IRigidBody Frut { get; set; }

        void GenerateNewFruit();

        /// <summary>
        /// соприкосновение с картой 
        /// </summary>

    }
}
