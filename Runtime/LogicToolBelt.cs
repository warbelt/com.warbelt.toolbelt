using UnityEngine;


namespace Warbelt.ToolBelt
{
    public static class LogicToolBelt
    {
        public static bool IsLayerInLayerMask(int layer, LayerMask layerMask)
        {
            return ((1 << layer) & layerMask.value) != 0;
        }
    }
}
