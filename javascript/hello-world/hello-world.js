var HelloWorld = function() {};

HelloWorld.prototype.hello = function(input) {
    var name = !input || input.trim() == "" ? "World" : input;
    return "Hello, " + name + "!";
};

module.exports = HelloWorld;