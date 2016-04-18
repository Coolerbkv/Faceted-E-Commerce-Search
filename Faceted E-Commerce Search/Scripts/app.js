var phonecatApp = angular.module('phonecatApp', [
    'ngRoute',
    'phonecatAnimations',
    'ui.bootstrap',
    'phonecatFilters',
    'phonecatControllers',
    'phonecatServices'
]);
phonecatApp.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/api/Products', {
            templateUrl: '/AngularViews/Index.html',
            controller: 'PhoneListCtrl',
            reloadOnSearch: false
        }).
        when('/api/Products/:PhoneId', {
            templateUrl: '/AngularViews/DetailsProduct.html',
            controller: 'PhoneDetailCtrl'
        }).
        otherwise({
            redirectTo: '/api/Products'
        });
  }]);
