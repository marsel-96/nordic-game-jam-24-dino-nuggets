using System;
using UnityEngine;

namespace _Project.Code.Scripts
{
    public enum DrawState
    {
        StartDraw,
        Draw,
        EndDraw,
        None
    }
    
    public class LineDrawer: MonoBehaviour
    {
        [SerializeField] private LineRenderer lineRenderer;
        [SerializeField] private new Camera camera;
        [SerializeField] private float distanceEpsilon = 1.5f;

        private DrawState _drawState;
        private float _distanceCamera;
        
        private void Awake()
        {
            _distanceCamera = Vector3.Distance(Vector3.zero, camera.transform.position);
        }
        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _drawState = DrawState.StartDraw;
                Debug.Log("Start Draw");
            }
            if (Input.GetMouseButtonUp(0))
            {
                _drawState = DrawState.EndDraw;
                Debug.Log("End Draw");
            }

            switch (_drawState)
            {
                case DrawState.StartDraw:
                {
                    StartDraw();
                    _drawState = DrawState.Draw;
                } break;
                case DrawState.Draw:
                {
                    Draw();
                } break;
                case DrawState.EndDraw:
                {
                    EndDraw();
                    _drawState = DrawState.None;
                } break;
                case DrawState.None: { } break;
                default: throw new ArgumentOutOfRangeException();
            }
        }
        
        private Vector3 GetMousePositionInWorld()
        {
            var mousePosition = Input.mousePosition;
            mousePosition.z = _distanceCamera - distanceEpsilon;
            var finalPosition = camera.ScreenToWorldPoint(mousePosition);
            finalPosition.y = distanceEpsilon;
            return finalPosition;
        }
        
        private void StartDraw()
        {
            var mousePosition = GetMousePositionInWorld();
            
            Debug.Log(mousePosition);
            
            lineRenderer.SetPosition(0, mousePosition);
            lineRenderer.SetPosition(1, mousePosition);
        }
        
        private void Draw()
        {
            var mousePosition = GetMousePositionInWorld();
            
            Debug.Log(mousePosition);

            lineRenderer.SetPosition(1, mousePosition);
        }
        
        private void EndDraw()
        {
            
        }
    }
}