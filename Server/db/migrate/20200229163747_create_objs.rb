class CreateObjs < ActiveRecord::Migration[6.0]
  def change
    create_table :objs do |t|
      t.string :name
      t.string :text
      t.string :position

      t.timestamps
    end
  end
end
