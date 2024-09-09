namespace SoccerPagination.Models
{
    public class IndexViewModelPlayers
    {
        public IEnumerable<Players> Players { get; }
        public PageViewModel PageViewModel { get; }

        public IndexViewModelPlayers(IEnumerable<Players> players, PageViewModel viewModel)
        {
            Players = players;
            PageViewModel = viewModel;
        }
    }
}
