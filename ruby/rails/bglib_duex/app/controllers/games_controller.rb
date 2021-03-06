class GamesController < ApplicationController
  before_action :set_game, only: [:show]

  def index
    @games = Game.all
    render json: @games
  end

  def show
    render json: @game
  end

  def new
    @game = Game.new
  end

  def create
    @game = Game.new(game_params)
    if @game.save
      # redirect_to @game, notice: "Game created."
      render json: @game
    else
      render json: {errors: @game.errors.full_messages, game: @game}
    end
  end

  private

  def set_game
    @game = Game.find(params[:id])
  end

  def game_params
    params.require(:game).permit(:title, :description, :min_players, :max_players, :publication_year)
  end
end
