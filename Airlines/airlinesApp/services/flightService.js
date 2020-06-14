(function (app) {
    var flightService = function ($http, $q) {

        this.getflights = function () {
            //return flights;
            return $http.get("/api/flights");
        }   

        this.selectflight = function (id) {
            return true;
        }

        var flights =
        [
                {
            id: 1,
            airline: "United",
            flightNumber: 207,
            startTime: "13:00",
            endTime: "15:00",
            totalDuration: 2,
            price: 500,
            date: '12/1/2014',
            cities: ["ORD", "LAS"],
            approved: false,
            selectText: 'Select',
            className: 'flightCard'
        },
        {
            id: 2,
            airline: "Commercial",
            flightNumber: 208,
            startTime: "13:30",
            endTime: "15:30",
            totalDuration: 2,
            price: 489,
            date: '12/1/2014',
            cities: ["SFO", "LAS"],
            approved: false,
            selectText: 'Select',
            className: 'flightCard'
        },
        {
            id: 3,
            airline: "Commercial",
            flightNumber: 208,
            startTime: "13:30",
            endTime: "15:30",
            totalDuration: 2,
            price: 489,
            date: '12/1/2014',
            cities: ["SFO", "LAS"],
            approved: false,
            selectText: 'Select',
            className: 'flightCard'
        },
        {
            id: 4,
            airline: "Commercial",
            flightNumber: 208,
            startTime: "13:30",
            endTime: "15:30",
            totalDuration: 2,
            price: 489,
            date: '12/1/2014',
            cities: ["SFO", "LAS"],
            approved: false,
            selectText: 'Select',
            className: 'flightCard'
        }
    ]
    };
    app.service("flightService", ['$http', '$q', flightService]);

}(angular.module("airlineApp")));

