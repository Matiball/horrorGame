using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour 
{
    public static AIController instance;

    private Animator aiAnimator;
    private NavMeshAgent agent;
    private AudioSource stepsSource;
    public bool seeEnemy { get; set; }

    public bool isMovingRandomly;
    public bool isChasingPlayer;
    public Transform nextRandomPoint;
    private Transform lastSpottedPlayerPos; 

    public Player player;
    public float targetDistanceToRandomPoint = 1f;
    public AudioClip sprintSteps, slowSteps, spottedSound;

    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        aiAnimator = gameObject.GetComponent<Animator>();
        stepsSource = gameObject.GetComponent<AudioSource>();

        aiAnimator.SetFloat("Speed", 1);
        StartMovingRandomly();
    }

    public void Update()
    {
        if(isMovingRandomly)
        {
            // ak sa dostanem na nahodny bod, tak vybrat dalsi nahodny bod
            if(Vector3.Distance(nextRandomPoint.position, transform.position) < targetDistanceToRandomPoint)
            {
                StartMovingRandomly();
            }
        }
    }

    public void StartToChase(Transform target)
    {
        if (!isChasingPlayer)
        {
            aiAnimator.SetFloat("Speed", 2);
            agent.speed = 3;
            stepsSource.clip = sprintSteps;
            stepsSource.Play();
            AudioSource.PlayClipAtPoint(spottedSound, target.position);
        }

        isChasingPlayer = true;
        isMovingRandomly = false;
        agent.SetDestination(target.position);
    }

    public void StartMovingRandomly()
    {
        isMovingRandomly = true;
        isChasingPlayer = false;

        aiAnimator.SetFloat("Speed", 1);
        agent.speed = 2;
        stepsSource.clip = slowSteps;
        stepsSource.Play();

        nextRandomPoint = NavmeshManager.instance.GetRandomPoint();
        agent.SetDestination(nextRandomPoint.position);
    }



    public void StopZombie()
    {
        agent.isStopped = true;
        aiAnimator.SetFloat("Speed", 0);
        aiAnimator.SetInteger("Attack", 0);
        stepsSource.Stop();
    }
}
