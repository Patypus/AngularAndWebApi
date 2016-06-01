var driverDetailsModule = angular.module('DriverDetails',
    [
        'ngRoute',
        'DriversModule',
        'PastSeasonsModule',
        'StandingsModule',
        'TeamsModule',
        'TracksModule'
    ]);


driverDetailsModule.config(function($routeProvider) {
    $routeProvider
        .when('/drivers', {
            templateUrl: 'app/Drivers/drivers.html',
            controller: 'DriversController',
            controllerAs: 'DriversController',
            requiresLogin: false
        })
        .when('/pastseasons', {
            templateUrl: 'app/PastSeasons/pastseasons.html',
            controller: 'PastSeasonsController',
            controllerAs: 'PastSeasonsController',
            requiresLogin: false
        })
        .when('/standings', {
            templateUrl: 'app/Standings/standings.html',
            controller: 'StandingsController',
            controllerAs: 'StandingsController',
            requiresLogin: false
        })
        .when('/teams', {
            templateUrl: 'app/Teams/teams.html',
            controller: 'TeamsController',
            controllerAs: 'TeamsController',
            requiresLogin: false
        })
        .when('/tracks', {
            templateUrl: 'app/Tracks/tracks.html',
            controller: 'TracksController',
            controllerAs: 'TracksController',
            requiresLogin: false
        })
})