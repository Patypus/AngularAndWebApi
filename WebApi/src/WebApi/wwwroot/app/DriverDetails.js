var driverDetailsModule = angular.module('DriverDetails',
    [
        'ngRoute',
        'PastSeasonsModule',
        'StandingsModule',
        'TeamsModule'
    ]);


driverDetailsModule.config(function($routeProvider) {
    $routeProvider
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
})