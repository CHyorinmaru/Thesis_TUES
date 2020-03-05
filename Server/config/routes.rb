Rails.application.routes.draw do
  resources :objs
  namespace :api, defaults: { format: :json } do
    # list of resources
 end
end
