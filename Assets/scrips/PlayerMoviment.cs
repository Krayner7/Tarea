using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoviment : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody2D _rigidbody2D;
    private float _horizontalDirection;
    public LayerMask groundLayer;
    private bool _isGrounded;
    public Transform groundCheckPosition;
    public float groudCheckRadius;
   // public Animator animator;
    private SpriteRenderer _Sprite;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _Sprite = GetComponent<SpriteRenderer>();
       // audioSurgue = GetComponent<AudioSource>();
    }

    public AudioSource audioSurgue;
    public AudioClip jumpAudioclip;



    void Update()
    {

        _horizontalDirection = Input.GetAxisRaw("Horizontal");
        _rigidbody2D.linearVelocityX = _horizontalDirection * speed;
        //animator.SetFloat("Movement", _rigidbody2D.linearVelocityX);

        if (_horizontalDirection != 0)
        {
            if (_horizontalDirection == 1)
            {
                _Sprite.flipX = false;
            }
            else
            {
                _Sprite.flipX = true;
            }
        }

        if (Physics2D.OverlapCircle(groundCheckPosition.position, groudCheckRadius, groundLayer))
        {

            _isGrounded = true;

        }
        else
        {
            _isGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rigidbody2D.AddForceY(jumpForce, ForceMode2D.Impulse);
           // audioSurgue.PlayOneShot(jumpAudioclip);
        }

        //animator.SetBool("isJumping", !_isGrounded);




    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheckPosition.position, groudCheckRadius);
    }

}
