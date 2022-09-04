using UnityEngine;

namespace Noran.Extension.Debugger
{
    [CreateAssetMenu(menuName = "ScriptableObject/UseDebugExtension", fileName = "UseDebugExtension")]
    public class UseDebugScriptableObject : ScriptableObject
    {
        [SerializeField] private bool useDebugExtension;
        public bool UseDebugExtension => useDebugExtension;
    }
}
