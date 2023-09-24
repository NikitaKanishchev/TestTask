using Photon.Pun;
using UnityEngine;

namespace PlayerLogic
{
    public class PlayerAnimation : MonoBehaviourPunCallbacks
    {
        private Animator anim;
        private PhotonView _view;

        private void Start() => 
            anim = GetComponent<Animator>();

        private void Update()
        {
            if (_view.IsMine)
            {
                var horizontalMove = Input.GetAxisRaw("Horizontal");
                var verticalMove = Input.GetAxisRaw("Vertical");
        
                Vector3 moveInput = new Vector3(horizontalMove, verticalMove);
        
                if (moveInput == Vector3.zero)
                    anim.SetBool("Run", false);
                else
                    anim.SetBool("Run", true);
            }
        }
    }
}

