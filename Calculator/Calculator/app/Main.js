BASE.require([
    "jQuery",
    "app.Calculator"
], function () {

    BASE.namespace("app");

    app.Main = function (elem, tags, scope) {
        var self = this;
        var $elem = $(elem);
        var calculator = new app.Calculator();

        var $addition = $(tags["addition"]);
        var $subtraction = $(tags["subtraction"]);
        var $division = $(tags["division"]);
        var $multiply = $(tags["multiply"]);
        var $Calculate = $(tags["Calculate"]);
        var $test = $(tags["test"]);
        var $leftSide = $(tags["left-side"]);
        var $rightSide = $(tags["right-side"]);
        var $answer = $(tags["answer"]);

        $Calculate.on("click", function () {
            var leftSide = parseInt($leftSide.val(), 10);
            var rightSide = parseInt($rightSide.val(), 10);
            var result = calculator.execute(leftSide, rightSide);
            $answer.text(result);
        });
        $addition.on("click", function () {
            calculator.setStateToAddition();
        });
        $subtraction.on("click", function () {
            calculator.setStateToSubtraction();
        });
        $division.on("click", function () {
            calculator.setStateToDivide();
        });
        $multiply.on("click", function () {
            calculator.setStateToMultiply();
        });
        $test.on("click", function () {
            console.log("This worked");
        });

    }
});