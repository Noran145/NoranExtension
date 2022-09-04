using UniRx;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Noran.Extension.Samples
{
    [RequireComponent(typeof(PlayerInput))]
    public class InputActionSample : MonoBehaviour
    {
        private PlayerInput playerInput;
        [SerializeField] private GameObject targetObject;
        [SerializeField] private FloatingJoystick left;
        [SerializeField] private FloatingJoystick right;
        
        private void Start()
        {
            var input = new NoranExtensionInputController(targetObject, left, right);

            Observable.EveryFixedUpdate().Subscribe(_ =>
            {
                input.ChangePosition();
                input.ChangeRotation();
            }).AddTo(gameObject);
        }

        public void OnMove(InputValue value)
        {
            Debug.Log(value.isPressed);
        }
    }
}
