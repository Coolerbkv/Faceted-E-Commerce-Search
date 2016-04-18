var phonecatControllers = angular.module('phonecatControllers', []);

phonecatControllers.controller('PhoneListCtrl', ['$scope', '$routeParams', '$location', 'Colors', 'Makers', 'OSs', 'CPUs', 'GPUs',
                                                  'RAMs', 'Diagonals', 'ReleaseYears', 'ResolutionScreens', 'Filter',
  function getData($scope, $routeParams, $location, Colors, Makers, OSs, CPUs, GPUs, RAMs, Diagonals, ReleaseYears, ResolutionScreens, Filter) {

      $scope.params = $.extend({}, $routeParams);
      $scope.products = Filter.query($.extend({ CurrentPage: 1 }, $routeParams));
      $scope.OnSelectEvent = function (pageNumber) {
          pageNumber = pageNumber || 1;
          var params = {
              SortByPrice: $scope.PriceOrder,
              ColorId: $scope.Color, MakerId: $scope.Maker,
              OSId: $scope.OS, CPU: $scope.CPU, Diagonal: $scope.Diagonal,
              GPU: $scope.GPU, RAM: $scope.RAM,
              ReleaseYear: $scope.ReleaseYear,
              ResolutionScreen: $scope.ResolutionScreen,
              CurrentPage: pageNumber
          };
          Object.keys(params).forEach(function (key) { $location.search(key, params[key]); });
          $scope.products = Filter.query({
              SortByPrice: $scope.PriceOrder,
              ColorId: $scope.Color, MakerId: $scope.Maker,
              OSId: $scope.OS, CPU: $scope.CPU, Diagonal: $scope.Diagonal,
              GPU: $scope.GPU, RAM: $scope.RAM,
              ReleaseYear: $scope.ReleaseYear,
              ResolutionScreen: $scope.ResolutionScreen,
              CurrentPage: pageNumber
          });
      }
      $scope.$on('$locationChangeSuccess', function () {
          $scope.products = Filter.query($.extend({ CurrentPage: 1 }, $routeParams));
      });
      $scope.colors = Colors.query();
      $scope.makers = Makers.query();
      $scope.os = OSs.query();
      $scope.cpu = CPUs.query();
      $scope.gpu = GPUs.query();
      $scope.ram = RAMs.query();
      $scope.diagonals = Diagonals.query();
      $scope.releaseYears = ReleaseYears.query();
      $scope.resolutionScreen = ResolutionScreens.query();
      $scope.maxCountPages = 5;
      $scope.$watch('products.CurrentPage', function (pageNumber) {
          $scope.OnSelectEvent(pageNumber);
      });
      $scope.PriceOrderList = [{ NameOrder: "Highest first", Value: "false" }, { NameOrder: "Lowest first", Value: "true" }];
  }
]);

phonecatControllers.controller('PhoneDetailCtrl', ['$scope', '$routeParams', 'Product',
  function ($scope, $routeParams, Product) {
      $scope.product = Product.get({ PhoneId: $routeParams.PhoneId }), function (product) {
          $scope.mainImageUrl = product.Pictures;
      };
      $scope.setImage = function (imageUrl) {
          $scope.mainImageUrl = imageUrl;
          $('img.phone:first-child').css('display', 'none');
      };
  }]);