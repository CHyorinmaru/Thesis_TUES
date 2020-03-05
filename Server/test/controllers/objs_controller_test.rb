require 'test_helper'

class ObjsControllerTest < ActionDispatch::IntegrationTest
  setup do
    @obj = objs(:one)
  end

  test "should get index" do
    get objs_url, as: :json
    assert_response :success
  end

  test "should create obj" do
    assert_difference('Obj.count') do
      post objs_url, params: { obj: { name: @obj.name, position: @obj.position, text: @obj.text } }, as: :json
    end

    assert_response 201
  end

  test "should show obj" do
    get obj_url(@obj), as: :json
    assert_response :success
  end

  test "should update obj" do
    patch obj_url(@obj), params: { obj: { name: @obj.name, position: @obj.position, text: @obj.text } }, as: :json
    assert_response 200
  end

  test "should destroy obj" do
    assert_difference('Obj.count', -1) do
      delete obj_url(@obj), as: :json
    end

    assert_response 204
  end
end
