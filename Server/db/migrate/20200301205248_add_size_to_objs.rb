class AddSizeToObjs < ActiveRecord::Migration[6.0]
  def change
    add_column :objs, :size, :string
  end
end
