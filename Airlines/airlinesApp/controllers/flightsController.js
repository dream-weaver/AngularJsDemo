(function (app) {

    var flightsController = function ($scope, flightService, $timeout) {
        $scope.flights = [];
        $scope.status = '';
        $scope.title = 'AIRLINES!';

        var init = function () {
            $scope.getFlights();
        };

        var onError = function () {
            alert("Error!");
        };

        var onFlights = function (response) {
            $scope.flights = response.data;
        };
        
        $scope.getFlights = function () {
            $scope.flights = flightService.getflights().then(onFlights, onError);
        };

        $scope.selectFlight = function (flight) {
            for (var i = 0; i < $scope.flights.length; i++) {
                $scope.flights[i].approved = false;
                $scope.flights[i].selectText = 'Select';
                $scope.flights[i].className = 'flightCard';
            }

            flight.approved = !flight.approved;
            flight.selectText = 'Selected';
            flight.className = 'flightCardSelected';

            if (flightService.selectflight(flight.id)) {
                $scope.status = 'You have made an amazing decision!'
                $timeout(function () {
                    $scope.status = null;
                }, 3000);
            }
        };

        init();
    };

    app.controller("flightsController", ["$scope", "flightService", "$timeout", flightsController]);

}(angular.module("airlineApp")));