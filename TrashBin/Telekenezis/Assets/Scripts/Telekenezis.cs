using UnityEngine;

public class Telekenezis : MonoBehaviour
{
    private GameObject[] _stones;
    [SerializeField] private float _telekenezisHeight;
    [SerializeField] private float _telekenezisPower;
    private bool _onGround = true;
    private bool _pushed = false;

    private void Start()
    {
        _stones = GameObject.FindGameObjectsWithTag("Stone");
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            _onGround = false;
        }

        if (!_onGround)
        {
            for (int i = 0; i < _stones.Length; i++)
            {
                _stones[i].transform.position = Vector3.MoveTowards(_stones[i].transform.position, new Vector3(_stones[i].transform.position.x, (_telekenezisHeight / _stones[i].GetComponent<Stone>().GetMass()),
                    _stones[i].transform.position.z), 0.1f);
            }
        }

        if (Input.GetKeyUp(KeyCode.Space) & !_onGround & !_pushed)
        {
            for (int i = 0; i < _stones.Length; i++)
            {
                _stones[i].GetComponent<Rigidbody>().isKinematic = false;
                _stones[i].GetComponent<Rigidbody>().AddForce(new Vector3(0,0,3)*_telekenezisPower);
            }
        }
    }
}
