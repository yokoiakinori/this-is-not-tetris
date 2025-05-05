using Cysharp.Threading.Tasks;
using UnityEngine.InputSystem;
using VContainer.Unity;

namespace Mino
{
    public class MinoPresenter: ITickable
    {
        private TetrisInputs _inputs;
        
        private readonly MinoView _minoView;
        private readonly MinoService _minoService;
        
        private readonly bool _isRunning = true;
        
        public MinoPresenter(MinoView minoView, MinoService minoService)
        { 
            _minoView = minoView;
            _minoService = minoService;
            
            _inputs = new TetrisInputs();
            _inputs.Mino.LeftMove.performed += OnLeftMove;
            _inputs.Mino.RightMove.performed += OnRightMove;
            _inputs.Mino.DownMove.performed += OnDownMove;
            _inputs.Mino.Rotate.performed += OnRotate;
            
            _inputs.Enable();
            
            AutoFall().Forget();
        }

        private void OnLeftMove(InputAction.CallbackContext context)
        {
            _minoService.MoveLeft();
        }
        
        private void OnRightMove(InputAction.CallbackContext context)
        {
            _minoService.MoveRight();
        }
        
        private void OnDownMove(InputAction.CallbackContext context)
        {
            _minoService.MoveDown();
        }
        
        private void OnRotate(InputAction.CallbackContext context)
        {
            _minoView.UpdateMinoRotation();
        }

        async UniTaskVoid AutoFall()
        {
            while (_isRunning)
            {
                await UniTask.Delay(1000);
                DownMove();
            }
        }

        private void DownMove()
        {
            _minoService.MoveDown();
        }

        public void Tick()
        {
            (int widthIndex, int heightIndex) = _minoService.GetPosition();
            _minoView.UpdateMinoPosition(widthIndex, heightIndex);
        }
    }
}