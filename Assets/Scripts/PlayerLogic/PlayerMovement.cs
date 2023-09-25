using App;
using Photon.Pun;
using Services.Input;
using UnityEngine;

namespace PlayerLogic
{
    public class PlayerMovement : MonoBehaviourPunCallbacks
    {
        [SerializeField] private Rigidbody2D _playerRigidbody = null;
        [SerializeField] private float _speed = 5f;
        [SerializeField] private float _rotateSpeed = 5f;
        [SerializeField] private PlayerWeapon _weapon;

        private const float Epsilon = 0.00001f;
        private PhotonView _view;

        private GameBootstrap _gameBootstrap;
        private IInputService _inputService;
        private Camera _camera;
        private Vector2 _moveDirection;
        
        
        public void Init(IInputService inputService)
        {
            _inputService = inputService;
        }

        private void Awake()
        {
            _gameBootstrap = FindObjectOfType<GameBootstrap>();
            _inputService = _gameBootstrap.InputService;
            _camera = Camera.main;
        }

        private void Start()
        {
            _view = GetComponent<PhotonView>();
        }

        private void Update()
        {
            if (photonView.IsMine)
            {
                _moveDirection = Vector2.zero;

                if (_inputService.Axis.sqrMagnitude > 0.00001f)
                {
                    _moveDirection = new Vector2(_inputService.Axis.x, _inputService.Axis.y).normalized;
                    
                    Quaternion moveRotation = Quaternion.LookRotation(Vector3.forward, _moveDirection);
                    transform.rotation = Quaternion.Lerp(transform.rotation, moveRotation, _rotateSpeed * Time.deltaTime);
                }
                
                if (_inputService.IsAttackButtonUp()) 
                    _weapon.Fire();
            }
        }

        private void FixedUpdate()
        {
            _playerRigidbody.velocity = new Vector2(_moveDirection.x * _speed, _moveDirection.y * _speed);
        }
    }
}