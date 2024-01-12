using MiradorWebAPI.ApiModels.Codeco;

namespace MiradorWebAPI.ApiModels.Esolde
{
    public class ReplayForSolde : Replay
    {
        public ApiEnsWaitSolde solde_records { get; set; }
    }
}
