using UnityEngine;


public class CannonController : MonoBehaviour
{
    public float maxYRotation;
    public float minYRotation;
    public float maxXRotation;
    public float minXRotation;
    public float rotationSpeed;

    public float projectileFireForce;

    // this will force gameobject that have cannon ball script inside of it
    public CannonBall projectilePrefab;

    public Transform barrelTransform;
    public Transform baseTransform;
    public Transform firePointTransform;

    private void Update()
    {
        AimCannon();
        TryFireCannon();
    }

    private void AimCannon()
    {
        // aim horizontal
        float newBaseRotation = baseTransform.localRotation.eulerAngles.y + rotationSpeed * Input.GetAxis("Mouse X");
        newBaseRotation = Mathf.Clamp(newBaseRotation, minYRotation, maxYRotation);

        baseTransform.localRotation = Quaternion.Euler(0, newBaseRotation, 0);

        // aim vertical
        float newBarrelRotation = barrelTransform.localRotation.eulerAngles.x - rotationSpeed * Input.GetAxis("Mouse Y");
        newBarrelRotation = Mathf.Clamp(newBarrelRotation, minXRotation, maxXRotation);
        barrelTransform.localRotation = Quaternion.Euler(newBarrelRotation, 0, 0);
    }

    private void TryFireCannon()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            CannonBall instantiatedBalls = Instantiate(projectilePrefab, firePointTransform.position, Quaternion.identity);
        }
    }

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;   
    }
}