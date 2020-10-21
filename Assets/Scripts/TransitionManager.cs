using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TransitionManager : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        DontDestroyOnLoad(gameObject);       
    }

    public void ChangeScene(string nextScene)
    {
        StartCoroutine(DoTransition(nextScene));
    }

    private IEnumerator DoTransition(string nextScene)
    {
        animator.Play("Transition_Show");
        yield return new WaitForSeconds(0.5f);
        yield return SceneManager.LoadSceneAsync(nextScene);
        animator.Play("Transition_Hide");
    }
}
