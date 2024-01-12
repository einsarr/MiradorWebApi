using MiradorWebAPI.ApiModels.Esolde;

namespace MiradorWebAPI.ApiModels.Finpronet
{
    public class ReplayForFinpronet : Replay
    {
        public ApiEnsWaitFinpronet solde_records { get; set; }
    }
}
