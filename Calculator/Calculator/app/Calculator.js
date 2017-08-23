BASE.namespace("app");

app.Calculator = function () {
    var self = this;
    

    var additionState = {
        execute: function (leftSide, rightSide) {
            return leftSide + rightSide;
            
        }
    };

    var subtractionState = {
        execute: function (leftSide, rightSide) {
            return leftSide - rightSide;
        }
    };

    var divideState = {
        execute: function (leftSide, rightSide) {
            return leftSide / rightSide;
        }
    };

    var multiplyState = {
        execute: function (leftSide, rightSide) {
            return leftSide * rightSide;
        }
    };
    
    var State = additionState;

    self.execute = function (leftSide, rightSide) {
        return State.execute(leftSide, rightSide);
    };
    self.setStateToAddition = function () {
        State = additionState;
    };

    self.setStateToSubtraction = function () {
        State = subtractionState;
    };

    self.setStateToDivide = function () {
        State = divideState;
    };
    
    self.setStateToMultiply = function () {
        State = multiplyState;
    };
};
