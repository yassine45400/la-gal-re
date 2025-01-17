<<<<<<< HEAD
using UnityEngine;
using Mirror;
public class PlayerSetup : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] componentsToDisable;
    Camera sceneCamera;
    public void Start()
    {
        if (!isLocalPlayer)
        {

            //on boucle sur tout les �lements de l'array pour les d�sactiver si ce n'est pas notre joueur
            for (int i = 0; i < componentsToDisable.Length; i++)
            {
                componentsToDisable[i].enabled = false;
            }
        }
        else
        {
            sceneCamera = Camera.main;
            if (sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(false);
            }
        }
    }

    private void OnDisable()
    {
        if (sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(true);
        }
    }

}
=======
using UnityEngine;
using Mirror;
public class PlayerSetup : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] componentsToDisable;
    Camera sceneCamera;
    public void Start()
    {
        if(!isLocalPlayer)
        {

            //on boucle sur tout les �lements de l'array pour les d�sactiver si ce n'est pas notre joueur
            for (int i = 0;  i < componentsToDisable.Length; i++)   
            {
                componentsToDisable[i].enabled = false;
            }
        }
        else
        {
            sceneCamera = Camera.main;
            if (sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(false);
            }
        }
    }

    private void OnDisable()
    {
        if (sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(true);
        }
    }

}
>>>>>>> dbd0af52a985d9fd971bd17757709b81a84789c8
