using UnityEngine;

namespace Noran.Extension.Samples
{
    public class DebugLogChecker : MonoBehaviour
    {
        [SerializeField] private GameObject targetObject;
        
        private void Start()
        {
            NoranExtension.DebugLogObjectName(targetObject);
            NoranExtension.DebugLogActionName(TestNameMethod);
        }

        private static void TestNameMethod()
        {
            Debug.Log("Action!!");
        }
    }
}
