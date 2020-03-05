class Obj < ApplicationRecord
    private
    def obj_json_response(obj_uuid)
        jsonize({
        Items: [{
            type: "obj",
            name: name,
            text: text,
            position: position
        }]
        })
    end
end
