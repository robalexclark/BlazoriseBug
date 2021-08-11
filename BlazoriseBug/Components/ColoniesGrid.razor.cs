using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazoriseBug.Components
{
    public partial class ColoniesGrid
    {
        private IEnumerable<Colony> colonies;

        private bool isLoading { get; set; }

        //protected override async Task OnAfterRenderAsync(bool firstRender)
        //{
        //    if (firstRender)
        //    {
        //        await RefreshColonies();
        //    }
        //}

        //private async Task RefreshColonies()
        //{
        //    isLoading = true;
        //    StateHasChanged();

        //    //using (BlazoriseBugRepository cairsRepository = new BlazoriseBugRepository(CairsContextFactory.CreateDbContext(), AuthenticationStateProvider))
        //    //{
        //    //    colonies = await cairsRepository.GetColonies(true);
        //    //}

        //    isLoading = false;
        //    StateHasChanged();
        //}
    }
}