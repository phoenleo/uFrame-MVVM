// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


[DiagramInfoAttribute("Checkers")]
public abstract class CheckerBoardViewBase : ViewBase {
    
    [UnityEngine.SerializeField()]
    private NewViewComponent _NewViewComponent;
    
    public override string DefaultIdentifier {
        get {
            return "CheckerBoard";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(CheckerBoardViewModel);
        }
    }
    
    public virtual NewViewComponent NewViewComponent {
        get {
            return _NewViewComponent ?? (_NewViewComponent = GetComponent<NewViewComponent>());
        }
        set {
            this._NewViewComponent = value;
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public CheckerBoardViewModel CheckerBoard {
        get {
            return ((CheckerBoardViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CheckerBoardController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
    }
}

[DiagramInfoAttribute("Checkers")]
public abstract class CheckerMoveViewBase : ViewBase {
    
    public override string DefaultIdentifier {
        get {
            return "CheckerMove";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(CheckerMoveViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return true;
        }
    }
    
    public CheckerMoveViewModel CheckerMove {
        get {
            return ((CheckerMoveViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CheckerMoveController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
    }
}

[DiagramInfoAttribute("Checkers")]
public abstract class CheckerPlateViewBase : ViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public bool _CanMoveTo;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Vector2 _Position;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public bool _IsEven;
    
    public override string DefaultIdentifier {
        get {
            return "CheckerPlate";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(CheckerPlateViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return true;
        }
    }
    
    public CheckerPlateViewModel CheckerPlate {
        get {
            return ((CheckerPlateViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CheckerPlateController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        CheckerPlateViewModel checkerPlate = ((CheckerPlateViewModel)(viewModel));
        checkerPlate.CanMoveTo = this._CanMoveTo;
        checkerPlate.Position = this._Position;
        checkerPlate.IsEven = this._IsEven;
    }
    
    public virtual void ExecuteSelectCommand() {
        this.ExecuteCommand(CheckerPlate.SelectCommand);
    }
}

[DiagramInfoAttribute("Checkers")]
public abstract class CheckersGameViewBase : ViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _BlackScore;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _RedScore;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public ViewBase _Board;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public ViewBase _CurrentChecker;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public CheckerType _CurrentPlayer;
    
    public override string DefaultIdentifier {
        get {
            return "CheckersGame";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(CheckersGameViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public CheckersGameViewModel CheckersGame {
        get {
            return ((CheckersGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CheckersGameController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        CheckersGameViewModel checkersGame = ((CheckersGameViewModel)(viewModel));
        checkersGame.BlackScore = this._BlackScore;
        checkersGame.RedScore = this._RedScore;
        checkersGame.Board = this._Board == null ? null : this._Board.ViewModelObject as CheckerBoardViewModel;
        checkersGame.CurrentChecker = this._CurrentChecker == null ? null : this._CurrentChecker.ViewModelObject as CheckerViewModel;
        checkersGame.CurrentPlayer = this._CurrentPlayer;
    }
    
    public virtual void ExecuteGameOver() {
        this.ExecuteCommand(CheckersGame.GameOver);
    }
}

[DiagramInfoAttribute("Checkers")]
public abstract class CheckerViewBase : ViewBase {
    
    [UnityEngine.SerializeField()]
    private KingMeStrategy _KingMeStrategy;
    
    [UnityEngine.SerializeField()]
    private ContiniousRotation _ContiniousRotation;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public bool _IsKingMe;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Vector2 _Position;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public bool _Selected;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public CheckerType _Type;
    
    public override string DefaultIdentifier {
        get {
            return "Checker";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(CheckerViewModel);
        }
    }
    
    public virtual KingMeStrategy KingMeStrategy {
        get {
            return _KingMeStrategy ?? (_KingMeStrategy = GetComponent<KingMeStrategy>());
        }
        set {
            this._KingMeStrategy = value;
        }
    }
    
    public virtual ContiniousRotation ContiniousRotation {
        get {
            return _ContiniousRotation ?? (_ContiniousRotation = GetComponent<ContiniousRotation>());
        }
        set {
            this._ContiniousRotation = value;
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return true;
        }
    }
    
    public CheckerViewModel Checker {
        get {
            return ((CheckerViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CheckerController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        CheckerViewModel checker = ((CheckerViewModel)(viewModel));
        checker.IsKingMe = this._IsKingMe;
        checker.Position = this._Position;
        checker.Selected = this._Selected;
        checker.Type = this._Type;
    }
    
    public virtual void ExecuteSelectCommand() {
        this.ExecuteCommand(Checker.SelectCommand);
    }
}

[DiagramInfoAttribute("Checkers")]
public abstract class AICheckersGameViewBase : CheckersGameViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public string _String1;
    
    public override System.Type ViewModelType {
        get {
            return typeof(AICheckersGameViewModel);
        }
    }
    
    
    public AICheckersGameViewModel AICheckersGame {
        get {
            return ((AICheckersGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<AICheckersGameController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        AICheckersGameViewModel aICheckersGame = ((AICheckersGameViewModel)(viewModel));
        aICheckersGame.String1 = this._String1;
    }
}

[DiagramInfoAttribute("Checkers")]
public abstract class MainMenuViewBase : ViewBase {
    
    public override string DefaultIdentifier {
        get {
            return "MainMenu";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(MainMenuViewModel);
        }
    }
    
    public MainMenuViewModel MainMenu {
        get {
            return ((MainMenuViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<MainMenuController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
    }
    
    public virtual void ExecutePlay() {
        this.ExecuteCommand(MainMenu.Play);
    }
}

public class CheckerPlateViewViewBase : CheckerPlateViewBase {
    
    [UFToggleGroup("CanMoveTo")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("CanMoveToChanged")]
    public bool _BindCanMoveTo = true;
    
    [UFToggleGroup("Position")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("PositionChanged")]
    public bool _BindPosition = true;
    
    [UFToggleGroup("IsEven")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("IsEvenChanged")]
    public bool _BindIsEven = true;
    
    public virtual void CanMoveToChanged(bool value) {
    }
    
    public virtual void PositionChanged(UnityEngine.Vector2 value) {
    }
    
    public virtual void IsEvenChanged(bool value) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindCanMoveTo) {
            this.BindProperty(()=>CheckerPlate._CanMoveToProperty, this.CanMoveToChanged);
        }
        if (this._BindPosition) {
            this.BindProperty(()=>CheckerPlate._PositionProperty, this.PositionChanged);
        }
        if (this._BindIsEven) {
            this.BindProperty(()=>CheckerPlate._IsEvenProperty, this.IsEvenChanged);
        }
    }
}

public partial class CheckerPlateView : CheckerPlateViewViewBase {
}

public class CheckerBoardViewViewBase : CheckerBoardViewBase {
    
    [UFToggleGroup("Checkers")]
    [UnityEngine.HideInInspector()]
    public bool _BindCheckers = true;
    
    [UnityEngine.HideInInspector()]
    public System.Collections.Generic.List<CheckerViewBase> _CheckersList;
    
    [UFGroup("Checkers")]
    [UnityEngine.HideInInspector()]
    public bool _CheckersSceneFirst;
    
    [UFGroup("Checkers")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _CheckersContainer;
    
    [UFToggleGroup("Plates")]
    [UnityEngine.HideInInspector()]
    public bool _BindPlates = true;
    
    [UnityEngine.HideInInspector()]
    public System.Collections.Generic.List<CheckerPlateViewBase> _PlatesList;
    
    [UFGroup("Plates")]
    [UnityEngine.HideInInspector()]
    public bool _PlatesSceneFirst;
    
    [UFGroup("Plates")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _PlatesContainer;
    
    public virtual void CheckersAdded(CheckerViewBase item) {
        this._CheckersList.Add(item);
    }
    
    public virtual void CheckersRemoved(CheckerViewBase item) {
        this._CheckersList.Remove(item);
        if (item != null && item.gameObject != null) UnityEngine.Object.Destroy(item.gameObject);
    }
    
    public virtual ViewBase CreateCheckersView(CheckerViewModel value) {
        return this.InstantiateView(value);
    }
    
    public virtual void PlatesAdded(CheckerPlateViewBase item) {
        this._PlatesList.Add(item);
    }
    
    public virtual void PlatesRemoved(CheckerPlateViewBase item) {
        this._PlatesList.Remove(item);
        if (item != null && item.gameObject != null) UnityEngine.Object.Destroy(item.gameObject);
    }
    
    public virtual ViewBase CreatePlatesView(CheckerPlateViewModel value) {
        return this.InstantiateView(value);
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindCheckers) {
            var binding = this.BindToViewCollection(() => CheckerBoard._CheckersProperty);
            if ((_CheckersContainer == null)) {
            }
            else {
                binding.SetParent(_CheckersContainer);
            }
            if (_CheckersSceneFirst) {
                binding.ViewFirst();
            }
            binding.SetAddHandler(item=>CheckersAdded(item as CheckerViewBase));
            binding.SetRemoveHandler(item=>CheckersRemoved(item as CheckerViewBase));
            binding.SetCreateHandler(viewModel=>{ return CreateCheckersView(viewModel as CheckerViewModel); }); ;
        }
        if (this._BindPlates) {
            var binding = this.BindToViewCollection(() => CheckerBoard._PlatesProperty);
            if ((_PlatesContainer == null)) {
            }
            else {
                binding.SetParent(_PlatesContainer);
            }
            if (_PlatesSceneFirst) {
                binding.ViewFirst();
            }
            binding.SetAddHandler(item=>PlatesAdded(item as CheckerPlateViewBase));
            binding.SetRemoveHandler(item=>PlatesRemoved(item as CheckerPlateViewBase));
            binding.SetCreateHandler(viewModel=>{ return CreatePlatesView(viewModel as CheckerPlateViewModel); }); ;
        }
    }
}

public partial class CheckerBoardView : CheckerBoardViewViewBase {
}

public class CheckerViewViewBase : CheckerViewBase {
    
    [UFToggleGroup("IsKingMe")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("IsKingMeChanged")]
    public bool _BindIsKingMe = true;
    
    [UFToggleGroup("Position")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("PositionChanged")]
    public bool _BindPosition = true;
    
    [UFToggleGroup("Selected")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("SelectedChanged")]
    public bool _BindSelected = true;
    
    [UFToggleGroup("Type")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("TypeChanged")]
    public bool _BindType = true;
    
    public virtual void IsKingMeChanged(bool value) {
    }
    
    public virtual void PositionChanged(UnityEngine.Vector2 value) {
    }
    
    public virtual void SelectedChanged(bool value) {
    }
    
    public virtual void TypeChanged(CheckerType value) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindIsKingMe) {
            this.BindProperty(()=>Checker._IsKingMeProperty, this.IsKingMeChanged);
        }
        if (this._BindPosition) {
            this.BindProperty(()=>Checker._PositionProperty, this.PositionChanged);
        }
        if (this._BindSelected) {
            this.BindProperty(()=>Checker._SelectedProperty, this.SelectedChanged);
        }
        if (this._BindType) {
            this.BindProperty(()=>Checker._TypeProperty, this.TypeChanged);
        }
    }
}

public partial class CheckerView : CheckerViewViewBase {
}

public class CheckersGameViewViewBase : CheckersGameViewBase {
    
    [UFToggleGroup("BlackScore")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("BlackScoreChanged")]
    public bool _BindBlackScore = true;
    
    [UFToggleGroup("RedScore")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("RedScoreChanged")]
    public bool _BindRedScore = true;
    
    [UFToggleGroup("Board")]
    [UnityEngine.HideInInspector()]
    public bool _BindBoard = true;
    
    [UFGroup("Board")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.GameObject _BoardPrefab;
    
    [UFToggleGroup("CurrentChecker")]
    [UnityEngine.HideInInspector()]
    public bool _BindCurrentChecker = true;
    
    [UFGroup("CurrentChecker")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.GameObject _CurrentCheckerPrefab;
    
    [UFToggleGroup("CurrentPlayer")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("CurrentPlayerChanged")]
    public bool _BindCurrentPlayer = true;
    
    [UFToggleGroup("AllowedMoves")]
    [UnityEngine.HideInInspector()]
    public bool _BindAllowedMoves = true;
    
    [UnityEngine.HideInInspector()]
    public System.Collections.Generic.List<CheckerMoveViewBase> _AllowedMovesList;
    
    [UFGroup("AllowedMoves")]
    [UnityEngine.HideInInspector()]
    public bool _AllowedMovesSceneFirst;
    
    [UFGroup("AllowedMoves")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _AllowedMovesContainer;
    
    public virtual void BlackScoreChanged(int value) {
    }
    
    public virtual void RedScoreChanged(int value) {
    }
    
    public virtual void BoardChanged(CheckerBoardViewModel value) {
        if (value == null && _Board != null && _Board.gameObject != null) {
            Destroy(_Board.gameObject);
        }
        if (_BoardPrefab == null ) {
            this._Board = ((CheckerBoardViewBase)(this.InstantiateView(value)));
        }
        else {
            this._Board = ((CheckerBoardViewBase)(this.InstantiateView(this._BoardPrefab, value)));
        }
    }
    
    public virtual void CurrentCheckerChanged(CheckerViewModel value) {
        if (value == null && _CurrentChecker != null && _CurrentChecker.gameObject != null) {
            Destroy(_CurrentChecker.gameObject);
        }
        if (_CurrentCheckerPrefab == null ) {
            this._CurrentChecker = ((CheckerViewBase)(this.InstantiateView(value)));
        }
        else {
            this._CurrentChecker = ((CheckerViewBase)(this.InstantiateView(this._CurrentCheckerPrefab, value)));
        }
    }
    
    public virtual void CurrentPlayerChanged(CheckerType value) {
    }
    
    public virtual void AllowedMovesAdded(CheckerMoveViewBase item) {
        this._AllowedMovesList.Add(item);
    }
    
    public virtual void AllowedMovesRemoved(CheckerMoveViewBase item) {
        this._AllowedMovesList.Remove(item);
        if (item != null && item.gameObject != null) UnityEngine.Object.Destroy(item.gameObject);
    }
    
    public virtual ViewBase CreateAllowedMovesView(CheckerMoveViewModel value) {
        return this.InstantiateView(value);
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindBlackScore) {
            this.BindProperty(()=>CheckersGame._BlackScoreProperty, this.BlackScoreChanged);
        }
        if (this._BindRedScore) {
            this.BindProperty(()=>CheckersGame._RedScoreProperty, this.RedScoreChanged);
        }
        if (this._BindBoard) {
            this.BindProperty(()=>CheckersGame._BoardProperty, this.BoardChanged);
        }
        if (this._BindCurrentChecker) {
            this.BindProperty(()=>CheckersGame._CurrentCheckerProperty, this.CurrentCheckerChanged);
        }
        if (this._BindCurrentPlayer) {
            this.BindProperty(()=>CheckersGame._CurrentPlayerProperty, this.CurrentPlayerChanged);
        }
        if (this._BindAllowedMoves) {
            var binding = this.BindToViewCollection(() => CheckersGame._AllowedMovesProperty);
            if ((_AllowedMovesContainer == null)) {
            }
            else {
                binding.SetParent(_AllowedMovesContainer);
            }
            if (_AllowedMovesSceneFirst) {
                binding.ViewFirst();
            }
            binding.SetAddHandler(item=>AllowedMovesAdded(item as CheckerMoveViewBase));
            binding.SetRemoveHandler(item=>AllowedMovesRemoved(item as CheckerMoveViewBase));
            binding.SetCreateHandler(viewModel=>{ return CreateAllowedMovesView(viewModel as CheckerMoveViewModel); }); ;
        }
    }
}

public partial class CheckersGameView : CheckersGameViewViewBase {
}

public class CheckersHudViewViewBase : CheckersGameViewBase {
    
    [UFToggleGroup("BlackScore")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("BlackScoreChanged")]
    public bool _BindBlackScore = true;
    
    [UFToggleGroup("RedScore")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("RedScoreChanged")]
    public bool _BindRedScore = true;
    
    [UFToggleGroup("CurrentPlayer")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("CurrentPlayerChanged")]
    public bool _BindCurrentPlayer = true;
    
    public virtual void BlackScoreChanged(int value) {
    }
    
    public virtual void RedScoreChanged(int value) {
    }
    
    public virtual void CurrentPlayerChanged(CheckerType value) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindBlackScore) {
            this.BindProperty(()=>CheckersGame._BlackScoreProperty, this.BlackScoreChanged);
        }
        if (this._BindRedScore) {
            this.BindProperty(()=>CheckersGame._RedScoreProperty, this.RedScoreChanged);
        }
        if (this._BindCurrentPlayer) {
            this.BindProperty(()=>CheckersGame._CurrentPlayerProperty, this.CurrentPlayerChanged);
        }
    }
}

public partial class CheckersHudView : CheckersHudViewViewBase {
}

public class MainMenuViewViewBase : MainMenuViewBase {
    
    public override void Bind() {
        base.Bind();
    }
}

public partial class MainMenuView : MainMenuViewViewBase {
}

public class AICheckersViewViewBase : CheckersGameView {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public string _String1;
    
    public AICheckersGameViewModel AICheckersGame {
        get {
            return ((AICheckersGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override void Bind() {
        base.Bind();
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        AICheckersGameViewModel aICheckersGame = ((AICheckersGameViewModel)(viewModel));
        aICheckersGame.String1 = this._String1;
    }
}

public partial class AICheckersView : AICheckersViewViewBase {
}

public partial class NewViewComponent : ViewComponent {
    
    public virtual CheckerBoardViewModel CheckerBoard {
        get {
            return ((CheckerBoardViewModel)(this.View.ViewModelObject));
        }
    }
}

public partial class NewViewComponent1 : NewViewComponent {
}

public partial class KingMeStrategy : ViewComponent {
    
    public virtual CheckerViewModel Checker {
        get {
            return ((CheckerViewModel)(this.View.ViewModelObject));
        }
    }
    
    public virtual void ExecuteSelectCommand() {
        this.View.ExecuteCommand(Checker.SelectCommand);
    }
}

public partial class DoubleUpKingMeStrategy : KingMeStrategy {
}

public partial class FlipOverKingMeStrategy : KingMeStrategy {
}

public partial class ContiniousRotation : ViewComponent {
    
    public virtual CheckerViewModel Checker {
        get {
            return ((CheckerViewModel)(this.View.ViewModelObject));
        }
    }
    
    public virtual void ExecuteSelectCommand() {
        this.View.ExecuteCommand(Checker.SelectCommand);
    }
}

public partial class MapView : ContiniousRotation {
}

public partial class PlayerScreenView : ContiniousRotation {
}
