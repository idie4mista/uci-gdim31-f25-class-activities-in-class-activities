using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] public float batSpeed = 1.0f;
    [SerializeField] public Animator animator;
    [SerializeField] private Transform _playerTransform; 
    private float _time;
    public void StopChase()
    {

        enabled = false;
    }

    public void StartChase()
    {
        enabled = true;
    }
   private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,_playerTransform.position,batSpeed);
    }
}
