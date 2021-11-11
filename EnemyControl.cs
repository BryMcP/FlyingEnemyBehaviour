using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBehaviour
{
    protected GameObject m_object;
    protected GameObject m_target;
    public Vector2 direction { get; set; }
    public bool WallBump = false;

    public EnemyBehaviour(GameObject owner)
    {
        m_object = owner;
        m_target = GameObject.Find("Player");
    }

    public abstract void Update();
}

public class Crawler: EnemyBehaviour
{
    private float fireCooldown = 2;
    private float fireTime;
    public GameObject projectile { get; set; }
    public float projectileSpeed { get; set; } = 3;
    public float speed { get; set; }
    [SerializeField] Transform crawlerFire;

    public Crawler(GameObject owner, GameObject projectile) : base(owner)
    {
        this.projectile = projectile;
    }

    public override void Update()
    {
        
        if (WallBump == false)
        {
            speed = 2.5f;

        }

        if (WallBump == true)
        {
            speed = -2.5f;
        }
        m_object.GetComponent<Rigidbody2D>().velocity = direction * speed;

        fireTime -= Time.deltaTime;
        if (fireTime < 0)
        {
            GameObject laser = GameObject.Instantiate(projectile);
            laser.transform.position = m_object.transform.position + m_object.transform.right * 1.5f;
            laser.transform.rotation = m_object.transform.rotation;
            laser.GetComponent<Rigidbody2D>().velocity = laser.transform.right * projectileSpeed;
            GameObject.Destroy(laser, 2.5f);
            fireTime = fireCooldown;
        }
    }
}

public class LeftStrafer : EnemyBehaviour
{
    private float fireCooldown = 2;
    private float fireTime;
    public GameObject projectile { get; set; }
    public float projectileSpeed { get; set; } = 4;
    public float speed { get; set; }
    [SerializeField] Transform lStraferFire;

    public LeftStrafer(GameObject owner, GameObject projectile) : base(owner)
    {
        this.projectile = projectile;
    }

    public override void Update()
    {
        if (WallBump == false)
        {
            speed = 3.5f;

        }

        if (WallBump == true)
        {
            speed = -3.5f;
        }
        m_object.GetComponent<Rigidbody2D>().velocity = direction * speed;

        fireTime -= Time.deltaTime;
        if (fireTime < 0)
        {
            GameObject laser = GameObject.Instantiate(projectile);
            laser.transform.position = m_object.transform.position + m_object.transform.right * 1.5f;
            laser.transform.rotation = m_object.transform.rotation;
            laser.GetComponent<Rigidbody2D>().velocity = laser.transform.right * projectileSpeed;
            GameObject.Destroy(laser, 2.5f);
            fireTime = fireCooldown;
        }
    }
}

public class RightStrafer : EnemyBehaviour
{
    private float fireCooldown = 2;
    private float fireTime;
    public GameObject projectile { get; set; }
    public float projectileSpeed { get; set; } = 4;
    public float speed { get; set; }
    [SerializeField] Transform rStraferFire;

    public RightStrafer(GameObject owner, GameObject projectile) : base(owner)
    {
        this.projectile = projectile;
    }

    public override void Update()
    {
        
        if (WallBump == false)
        {
            speed = -3.5f;

        }

        if (WallBump == true)
        {
            speed = 3.5f;
        }
        m_object.GetComponent<Rigidbody2D>().velocity = direction * speed;

        fireTime -= Time.deltaTime;
        if (fireTime < 0)
        {
            GameObject laser = GameObject.Instantiate(projectile);
            laser.transform.position = m_object.transform.position + m_object.transform.right * 1.5f;
            laser.transform.rotation = m_object.transform.rotation;
            laser.GetComponent<Rigidbody2D>().velocity = laser.transform.right * projectileSpeed;
            GameObject.Destroy(laser, 2.5f);
            fireTime = fireCooldown;
        }
    }
}

public class Destroyer : EnemyBehaviour
{
    private float fireCooldown = 2;
    private float fireTime;
    public GameObject projectile;
    public float projectileSpeed { get; set; } = 3;
    public float speed { get; set; }
    private int health = 15;
    [SerializeField] Transform destroyerFirstFire;
    [SerializeField] Transform destroyerSecondFire;
    [SerializeField] Transform destroyerThirdFire;
    [SerializeField] Transform destroyerFourthFire;
    [SerializeField] Transform destroyerFifthFire;
    [SerializeField] Transform destroyerSixthFire;
    [SerializeField] Transform destroyerSeventhFire;
    [SerializeField] Transform destroyerEightthFire;
    private int i;
    private int f;

    public Destroyer(GameObject owner, GameObject projectile) : base(owner)
    {
        this.projectile = projectile;
    }

    public override void Update()
    {
        if (WallBump == false)
        {
            speed = 1.5f;

        }

        if (WallBump == true)
        {
            speed = -1.5f;
        }
        m_object.GetComponent<Rigidbody2D>().velocity = direction * speed;

        fireTime -= Time.deltaTime;
        if (fireTime < 0)
        {

            for (i = 0; i < 3; i++)
            {
                f = Random.Range(0, 7);

                if (f == 0)
                {
                    GameObject laser = GameObject.Instantiate(projectile);
                    laser.transform.position = destroyerFirstFire.transform.position + m_object.transform.right * 1.5f;
                    laser.transform.rotation = destroyerFirstFire.transform.rotation;
                    laser.GetComponent<Rigidbody2D>().velocity = laser.transform.right * projectileSpeed;
                    GameObject.Destroy(laser, 2.5f);
                    fireTime = fireCooldown;
                }
                else if (f == 1)
                {
                    GameObject laser = GameObject.Instantiate(projectile);
                    laser.transform.position = destroyerSecondFire.transform.position + m_object.transform.right * 1.5f;
                    laser.transform.rotation = destroyerSecondFire.transform.rotation;
                    laser.GetComponent<Rigidbody2D>().velocity = laser.transform.right * projectileSpeed;
                    GameObject.Destroy(laser, 2.5f);
                    fireTime = fireCooldown;
                }
                else if (f == 2)
                {
                    GameObject laser = GameObject.Instantiate(projectile);
                    laser.transform.position = destroyerThirdFire.transform.position + m_object.transform.right * 1.5f;
                    laser.transform.rotation = destroyerThirdFire.transform.rotation;
                    laser.GetComponent<Rigidbody2D>().velocity = laser.transform.right * projectileSpeed;
                    GameObject.Destroy(laser, 2.5f);
                    fireTime = fireCooldown;
                }
                else if (f == 3)
                {
                    GameObject laser = GameObject.Instantiate(projectile);
                    laser.transform.position = destroyerFourthFire.transform.position + m_object.transform.right * 1.5f;
                    laser.transform.rotation = destroyerFourthFire.transform.rotation;
                    laser.GetComponent<Rigidbody2D>().velocity = laser.transform.right * projectileSpeed;
                    GameObject.Destroy(laser, 2.5f);
                    fireTime = fireCooldown;
                }
                else if (f == 4)
                {
                    GameObject laser = GameObject.Instantiate(projectile);
                    laser.transform.position = destroyerFifthFire.transform.position + m_object.transform.right * 1.5f;
                    laser.transform.rotation = destroyerFifthFire.transform.rotation;
                    laser.GetComponent<Rigidbody2D>().velocity = laser.transform.right * projectileSpeed;
                    GameObject.Destroy(laser, 2.5f);
                    fireTime = fireCooldown;
                }
                else if (f == 5)
                {
                    GameObject laser = GameObject.Instantiate(projectile);
                    laser.transform.position = destroyerSixthFire.transform.position + m_object.transform.right * 1.5f;
                    laser.transform.rotation = destroyerSixthFire.transform.rotation;
                    laser.GetComponent<Rigidbody2D>().velocity = laser.transform.right * projectileSpeed;
                    GameObject.Destroy(laser, 2.5f);
                    fireTime = fireCooldown;
                }
                else if (f == 6)
                {
                    GameObject laser = GameObject.Instantiate(projectile);
                    laser.transform.position = destroyerSeventhFire.transform.position + m_object.transform.right * 1.5f;
                    laser.transform.rotation = destroyerSeventhFire.transform.rotation;
                    laser.GetComponent<Rigidbody2D>().velocity = laser.transform.right * projectileSpeed;
                    GameObject.Destroy(laser, 2.5f);
                    fireTime = fireCooldown;
                }
                else if (f == 7)
                {
                    GameObject laser = GameObject.Instantiate(projectile);
                    laser.transform.position = destroyerEightthFire.transform.position + m_object.transform.right * 1.5f;
                    laser.transform.rotation = destroyerEightthFire.transform.rotation;
                    laser.GetComponent<Rigidbody2D>().velocity = laser.transform.right * projectileSpeed;
                    GameObject.Destroy(laser, 2.5f);
                    fireTime = fireCooldown;
                }
            }
        }
    }
}

public class EnemyControl : MonoBehaviour
{
    [SerializeField] int health { get; set; }
    [SerializeField] AudioSource audio;
    [SerializeField] float animSpeed = 0.5f;
    [SerializeField] GameObject projectile;

    enum BehaviourType { crawler, leftstrafer, rightstrafer, destroyer };
    [SerializeField] BehaviourType behaviour;
    EnemyBehaviour m_enemyBehaviour;
    Rigidbody2D m_ship;
  
	// Use this for initialization
	void Start ()
    {
        m_ship = GetComponent<Rigidbody2D>();

        switch (behaviour)
        {
            case BehaviourType.crawler:
                m_enemyBehaviour = new Crawler(gameObject, projectile);
                health = 3;
                break;

            case BehaviourType.leftstrafer:
                m_enemyBehaviour = new LeftStrafer(gameObject, projectile);
                health = 5;
                break;

            case BehaviourType.rightstrafer:
                m_enemyBehaviour = new RightStrafer(gameObject, projectile);
                health = 5;
                break;

            case BehaviourType.destroyer:
                m_enemyBehaviour = new Destroyer(gameObject, projectile);
                health = 15;
                break;

        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("playerFire"))
        {
            health--;
            Destroy(collision.gameObject);

            if (health == 0)
            {
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
