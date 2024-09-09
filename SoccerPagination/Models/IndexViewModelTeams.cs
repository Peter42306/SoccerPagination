namespace SoccerPagination.Models
{
    public class IndexViewModelTeams
    {
        public IEnumerable<Teams> Teams { get; }
        public PageViewModel PageViewModel { get; }

        public IndexViewModelTeams(IEnumerable<Teams> teams, PageViewModel viewModel)
        {
            Teams=teams;
            PageViewModel = viewModel;
        }
    }
}
